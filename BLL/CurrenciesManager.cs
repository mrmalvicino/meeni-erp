using System;
using DAL;
using Entities;

namespace BLL
{
    public class CurrenciesManager
    {
        // ATTRIBUTES

        Database _database = new Database();

        // METHODS

        public Currency readCurrency(int currencyId)
        {
            Currency currency = new Currency();

            try
            {
                _database.setQuery("select Code, CurrencyName, Rate, BlackRate from Currencies where CurrencyId = @CurrencyId");
                _database.setParameter("@CurrencyId", currencyId);
                _database.executeReader();

                if (_database.Reader.Read())
                {
                    currency.CurrencyId = currencyId;
                    currency.Code = (string)_database.Reader["Code"];
                    currency.Name = (string)_database.Reader["CurrencyName"];
                    currency.Rate = (decimal)_database.Reader["Rate"];
                    if (!(_database.Reader["BlackRate"] is DBNull))
                        currency.BlackRate = (decimal)_database.Reader["BlackRate"];
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _database.closeConnection();
            }

            return currency;
        }
    }
}
