using System;
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
                _database.setQuery("select TaxCodeId, Prefix, Number, Suffix from TaxCodes where TaxCodeId = @TaxCodeId");
                _database.setParameter("@TaxCodeId", taxCodeId);
                _database.executeReader();

                if (_database.Reader.Read())
                {
                    taxCode.TaxCodeId = (int)_database.Reader["TaxCodeId"];

                    if (!(_database.Reader["Prefix"] is DBNull))
                        taxCode.Prefix = (string)_database.Reader["Prefix"];

                    taxCode.Number = (string)_database.Reader["Number"];

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
                _database.setQuery("insert into TaxCodes (Prefix, Number, Suffix) values (@Prefix, @Number, @Suffix)");
                _database.setParameter("@Prefix", taxCode.Prefix);
                _database.setParameter("@Number", taxCode.Number);
                _database.setParameter("@Suffix", taxCode.Suffix);
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
                _database.setQuery("update TaxCodes set Prefix = @Prefix, Number = @Number, Suffix = @Suffix where TaxCodeId = @TaxCodeId");
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
                _database.setQuery("delete from TaxCodes where TaxCodeId = @TaxCodeId");
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
