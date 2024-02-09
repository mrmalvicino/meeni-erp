using DAL;
using Entities;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class TaxCodesManager
    {
        // ATTRIBUTES

        private Database _database = new Database();

        // METHODS

        public List<TaxCode> listTaxCodes()
        {
            List<TaxCode> taxCodesList = new List<TaxCode>();

            try
            {
                _database.setQuery("SELECT TaxCodeId, TaxCodePrefix, TaxCodeNumber, TaxCodeSuffix FROM taxCodes");
                _database.executeReader();

                while (_database.Reader.Read())
                {
                    TaxCode taxCode = new TaxCode();

                    taxCode.TaxCodeId = (int)_database.Reader["TaxCodeId"];
                    taxCode.Prefix = (string)_database.Reader["TaxCodePrefix"];
                    taxCode.Number = (int)_database.Reader["TaxCodeNumber"];
                    taxCode.Suffix = (string)_database.Reader["TaxCodeSuffix"];

                    taxCodesList.Add(taxCode);
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

            return taxCodesList;
        }

        public void add(TaxCode taxCode)
        {
            try
            {
                _database.setQuery("INSERT INTO taxCodes (TaxCodePrefix, TaxCodeNumber, TaxCodeSuffix) VALUES (@TaxCodePrefix, @TaxCodeNumber, @TaxCodeSuffix)");

                _database.setParameter("@TaxCodePrefix", taxCode.Prefix);
                _database.setParameter("@TaxCodeNumber", taxCode.Number);
                _database.setParameter("@TaxCodeSuffix", taxCode.Suffix);

                _database.executeAction();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _database.closeConnection();
            }
        }

        public void edit(TaxCode taxCode)
        {
            try
            {
                _database.setQuery("UPDATE taxCodes SET TaxCodePrefix = @TaxCodePrefix, TaxCodeNumber = @TaxCodeNumber, TaxCodeSuffix = @TaxCodeSuffix WHERE TaxCodeId = @TaxCodeId");

                _database.setParameter("@TaxCodeId", taxCode.TaxCodeId);
                _database.setParameter("@TaxCodePrefix", taxCode.Prefix);
                _database.setParameter("@TaxCodeNumber", taxCode.Number);
                _database.setParameter("@TaxCodeSuffix", taxCode.Suffix);

                _database.executeAction();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _database.closeConnection();
            }
        }

        public void delete(TaxCode taxCode)
        {
            try
            {
                _database.setQuery("DELETE FROM taxCodes WHERE TaxCodeId = @TaxCodeId");
                _database.setParameter("@TaxCodeId", taxCode.TaxCodeId);
                _database.executeAction();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _database.closeConnection();
            }
        }
    }
}
