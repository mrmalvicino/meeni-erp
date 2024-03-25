using System;
using DAL;
using Entities;
using Utilities;

namespace BLL
{
    public class TaxCodesManager
    {
        // ATTRIBUTES

        private Database _database = new Database();

        // METHODS

        public TaxCode read(int taxCodeId)
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
                    {
                        taxCode.Prefix = (string)_database.Reader["Prefix"];
                    }

                    taxCode.Number = (string)_database.Reader["Number"];

                    if (!(_database.Reader["Suffix"] is DBNull))
                    {
                        taxCode.Suffix = (string)_database.Reader["Suffix"];
                    }
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
                setParameters(taxCode);
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
                setParameters(taxCode);
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

        public int getId(TaxCode taxCode)
        {
            if (taxCode == null)
            {
                return 0;
            }

            taxCode.TaxCodeId = 0;

            try
            {
                _database.setQuery("select TaxCodeId from TaxCodes where Number = @Number");
                _database.setParameter("@Number", taxCode.Number);
                _database.executeReader();

                if (_database.Reader.Read())
                {
                    taxCode.TaxCodeId = (int)_database.Reader["TaxCodeId"];
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

            return taxCode.TaxCodeId;
        }

        private void setParameters(TaxCode taxCode)
        {
            if (Validations.hasData(taxCode.Prefix))
            {
                _database.setParameter("@Prefix", taxCode.Prefix);
            }
            else
            {
                _database.setParameter("@Prefix", DBNull.Value);
            }

            if (Validations.hasData(taxCode.Number))
            {
                _database.setParameter("@Number", taxCode.Number);
            }
            else
            {
                _database.setParameter("@Number", DBNull.Value);
            }

            if (Validations.hasData(taxCode.Suffix))
            {
                _database.setParameter("@Suffix", taxCode.Suffix);
            }
            else
            {
                _database.setParameter("@Suffix", DBNull.Value);
            }
        }
    }
}
