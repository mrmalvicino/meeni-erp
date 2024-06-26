﻿using System;
using System.Collections.Generic;
using DAL;
using Entities;

namespace BLL
{
    public class BrandsManager
    {
        // ATTRIBUTES

        private Database _database = new Database();

        // METHODS

        public List<Brand> list(int categoryId = 0)
        {
            List<Brand> brandsList = new List<Brand>();
            string query = "select BrandId, BrandName from Brands";

            if (0 < categoryId)
            {
                query = "select B.BrandId, B.BrandName from Products P inner join Items I on I.ItemId = P.ItemId inner join Categories C on C.CategoryId = I.CategoryId inner join Models M on M.ModelId = P.ModelId inner join Brands B on B.BrandId = M.BrandId where C.CategoryId = @CategoryId";
                _database.setParameter("@CategoryId", categoryId);
            }

            try
            {
                _database.setQuery(query);
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
                _database.setQuery("select BrandName from Brands where BrandId = @BrandId");
                _database.setParameter("@BrandId", brandId);
                _database.executeReader();

                if (_database.Reader.Read())
                {
                    brand.BrandId = brandId;
                    brand.Name = (string)_database.Reader["BrandName"];
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
                _database.setQuery("insert into Brands (BrandName) values (@BrandName)");
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
                _database.setQuery("update Brands set BrandName = @BrandName where BrandId = @BrandId");
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
                _database.setQuery("select BrandId from Brands where BrandName = @BrandName");
                _database.setParameter("@BrandName", brand.Name);
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
            _database.setParameter("@BrandName", brand.Name);
        }
    }
}
