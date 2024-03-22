﻿using System;
using DAL;
using Entities;

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

        public int getId(TaxCode taxCode)
        {
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
    }
}
