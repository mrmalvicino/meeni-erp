using System;
using System.Collections.Generic;
using DAL;
using Entities;

namespace BLL
{
    public class TaxCodesManager
    {
        // ATTRIBUTES

        private Database _database = new Database();

        // METHODS

        public TaxCode readTaxCode(int taxCodeId)
        {
            TaxCode taxCode = new TaxCode();

            try
            {
                _database.setQuery("select Prefix, Number, Suffix from TaxCodes where TaxCodeId = @TaxCodeId");
                _database.setParameter("@TaxCodeId", taxCodeId);
                _database.executeReader();

                if (_database.Reader.Read())
                {
                    taxCode.TaxCodeId = taxCodeId;
                    if (!(_database.Reader["Prefix"] is DBNull))
                        taxCode.Prefix = (string)_database.Reader["Prefix"];
                    taxCode.Number = (int)_database.Reader["Number"];
                    if (!(_database.Reader["Suffix"] is DBNull))
                        taxCode.Suffix = (string)_database.Reader["Suffix"];
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

            return taxCode;
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

        public void delete(int taxCodeId)
        {
            try
            {
                _database.setQuery("DELETE FROM taxCodes WHERE TaxCodeId = @TaxCodeId");
                _database.setParameter("@TaxCodeId", taxCodeId);
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
