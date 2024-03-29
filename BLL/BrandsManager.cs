using System;
using System.Collections.Generic;
using DAL;
using Entities;
using Utilities;

namespace BLL
{
    public class BrandsManager
    {
        // ATTRIBUTES

        private Database _database = new Database();

        // METHODS

        public List<Brand> list()
        {
            List<Brand> brandsList = new List<Brand>();

            try
            {
                _database.setQuery("select BrandId, BrandName from Brands");
                _database.executeReader();

                while (_database.Reader.Read())
                {
                    Brand brand = new Brand();

                    brand.BrandId = Convert.ToInt32(_database.Reader["BrandId"]);
                    brand.Name = (string)_database.Reader["BrandName"];

                    brandsList.Add(brand);
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

            return brandsList;
        }

        public Brand read(int brandId)
        {
            Brand brand = new Brand();

            try
            {
                _database.setQuery("select Prefix, Number, Suffix from Brands where BrandId = @BrandId");
                _database.setParameter("@BrandId", brandId);
                _database.executeReader();

                if (_database.Reader.Read())
                {
                    brand.BrandId = brandId;

                    if (!(_database.Reader["Prefix"] is DBNull))
                    {
                        brand.Prefix = (string)_database.Reader["Prefix"];
                    }

                    brand.Number = (string)_database.Reader["Number"];

                    if (!(_database.Reader["Suffix"] is DBNull))
                    {
                        brand.Suffix = (string)_database.Reader["Suffix"];
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

            return brand;
        }

        public void add(Brand brand)
        {
            try
            {
                _database.setQuery("insert into Brands (Prefix, Number, Suffix) values (@Prefix, @Number, @Suffix)");
                setParameters(brand);
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

        public void edit(Brand brand)
        {
            try
            {
                _database.setQuery("update Brands set Prefix = @Prefix, Number = @Number, Suffix = @Suffix where BrandId = @BrandId");
                _database.setParameter("@BrandId", brand.BrandId);
                setParameters(brand);
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

        public int getId(Brand brand)
        {
            if (brand == null)
            {
                return 0;
            }

            int brandId = 0;

            try
            {
                _database.setQuery("select BrandId from Brands where Number = @Number");
                _database.setParameter("@Number", brand.Number);
                _database.executeReader();

                if (_database.Reader.Read())
                {
                    brandId = (int)_database.Reader["BrandId"];
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

            return brandId;
        }

        private void setParameters(Brand brand)
        {
            if (Validations.hasData(brand.Prefix, 2, 2))
            {
                _database.setParameter("@Prefix", brand.Prefix);
            }
            else
            {
                _database.setParameter("@Prefix", DBNull.Value);
            }

            if (Validations.hasData(brand.Number))
            {
                _database.setParameter("@Number", brand.Number);
            }
            else
            {
                _database.setParameter("@Number", DBNull.Value);
            }

            if (Validations.hasData(brand.Suffix, 1, 1))
            {
                _database.setParameter("@Suffix", brand.Suffix);
            }
            else
            {
                _database.setParameter("@Suffix", DBNull.Value);
            }
        }
    }
}
