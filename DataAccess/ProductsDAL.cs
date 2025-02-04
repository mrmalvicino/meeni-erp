using DomainModel;
using Exceptions;
using System;
using System.Collections.Generic;
using Utilities;

namespace DataAccess
{
    public class ProductsDAL
    {
        private Database _db;

        public ProductsDAL(Database db)
        {
            _db = db;
        }

        public int Create(Product product, int organizationId)
        {
            try
            {
                _db.SetProcedure("sp_create_product");
                SetParameters(product, organizationId);
                product.Id = _db.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ex);
            }
            finally
            {
                _db.CloseConnection();
            }

            return product.Id;
        }

        public Product Read(int productId)
        {
            try
            {
                _db.SetQuery("select * from products where product_id = @product_id");
                _db.SetParameter("@product_id", productId);
                _db.ExecuteRead();

                if (_db.Reader.Read())
                {
                    Product product = new Product();
                    ReadRow(product);
                    return product;
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ex);
            }
            finally
            {
                _db.CloseConnection();
            }
        }

        public void Update(Product product)
        {
            try
            {
                _db.SetProcedure("sp_update_product");
                SetParameters(product, 0, true);
                _db.ExecuteAction();
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ex);
            }
            finally
            {
                _db.CloseConnection();
            }
        }

        public void Toggle(int productId)
        {
            try
            {
                _db.SetProcedure("sp_toggle_product");
                _db.SetParameter("@product_id", productId);
                _db.ExecuteAction();
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ex);
            }
            finally
            {
                _db.CloseConnection();
            }
        }

        public List<Product> List(int organizationId, bool active, bool inactive)
        {
            List<Product> products = new List<Product>();

            try
            {
                _db.SetProcedure("sp_list_products");
                _db.SetParameter("@organization_id", organizationId);
                _db.SetParameter("@list_active", active);
                _db.SetParameter("@list_inactive", inactive);
                _db.ExecuteRead();

                while (_db.Reader.Read())
                {
                    Product product = new Product();
                    ReadRow(product);
                    products.Add(product);
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ex);
            }
            finally
            {
                _db.CloseConnection();
            }

            return products;
        }

        public int FindOrganizationId(int productId)
        {
            try
            {
                _db.SetProcedure("sp_find_product_organization_id");
                _db.SetParameter("@product_id", productId);
                _db.ExecuteRead();

                if (_db.Reader.Read())
                {
                    return (int)_db.Reader["organization_id"];
                }

                return 0;
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ex);
            }
            finally
            {
                _db.CloseConnection();
            }
        }

        private void SetParameters(Product product, int organizationId = 0, bool isUpdate = false)
        {
            if (isUpdate)
            {
                _db.SetParameter("@product_id", product.Id);
            }

            _db.SetParameter("@is_service", product.IsService);
            _db.SetParameter("@name", product.Name);

            if (!string.IsNullOrEmpty(product.Description))
            {
                _db.SetParameter("@description", product.Description);
            }
            else
            {
                _db.SetParameter("@description", DBNull.Value);
            }

            if (!string.IsNullOrEmpty(product.SKU))
            {
                _db.SetParameter("@sku", product.SKU);
            }
            else
            {
                _db.SetParameter("@sku", DBNull.Value);
            }

            _db.SetParameter("@price", product.Price);
            _db.SetParameter("@cost", product.Cost);

            if (product.Brand != null)
            {
                _db.SetParameter("@brand_id", product.Brand.Id);
            }
            else
            {
                _db.SetParameter("@brand_id", DBNull.Value);
            }

            if (0 < organizationId)
            {
                _db.SetParameter("@organization_id", organizationId);
            }
        }

        private void ReadRow(Product product)
        {
            product.Id = Convert.ToInt32(_db.Reader["product_id"]);
            product.ActivityStatus = Convert.ToBoolean(_db.Reader["activity_status"]);
            product.IsService = Convert.ToBoolean(_db.Reader["is_service"]);
            product.Name = _db.Reader["name"].ToString();
            product.Description = _db.Reader["description"].ToString();
            product.SKU = _db.Reader["sku"]?.ToString();
            product.Price = _db.Reader["price"] as decimal? ?? product.Price;
            product.Cost = _db.Reader["cost"] as decimal? ?? product.Cost;
            product.Brand = Helper.Instantiate<Brand>(_db.Reader["brand_id"]);
        }
    }
}
