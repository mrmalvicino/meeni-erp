using DAL;
using Entities;

namespace BLL
{
    public class CurrenciesManager
    {
        // ATTRIBUTES

        Database _database = new Database();

        // METHODS

        protected void readCurrency(Currency currency, int currencyId)
        {
            _database.setQuery($"SELECT Code, Name, Rate, BlackRate FROM currencies WHERE CurrencyId = {currencyId}");
            _database.executeReader();

            currency.Code = (string)_database.Reader["CountryName"];
            currency.Name = (string)_database.Reader["Name"];
            currency.Rate = (decimal)_database.Reader["Rate"];
            currency.BlackRate = (decimal)_database.Reader["BlackRate"];
        }
    }
}
