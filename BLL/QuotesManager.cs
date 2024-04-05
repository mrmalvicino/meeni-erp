using System;
using System.Collections.Generic;
using DAL;
using Entities;
using Utilities;

namespace BLL
{
    public class QuotesManager
    {
        // ATTRIBUTES

        private Database _database = new Database();
        private CustomersManager _customersManager = new CustomersManager();
        private ProductsManager _productsManager = new ProductsManager();
        private ServicesManager _servicesManager = new ServicesManager();

        // METHODS

        public List<Quote> list()
        {
            List<Quote> quotesList = new List<Quote>();

            try
            {
                _database.setQuery("select QuoteId, ActiveStatus, VariantVersion, JobDate, CustomerId from Quotes");
                _database.executeReader();

                while (_database.Reader.Read())
                {
                    Quote quote = new Quote();

                    quote.QuoteId = (int)_database.Reader["QuoteId"];
                    quote.ActiveStatus = (string)_database.Reader["ActiveStatus"];
                    quote.VariantVersion = Convert.ToInt32(_database.Reader["VariantVersion"]);
                    quote.JobDate = (DateTime)_database.Reader["JobDate"];
                    quote.Customer.CustomerId = (int)_database.Reader["CustomerId"];

                    quotesList.Add(quote);
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

            foreach (Quote quote in quotesList)
            {
                quote.Customer = _customersManager.read(quote.Customer.CustomerId);
            }

            return quotesList;
        }

        public List<QuoteRow> read(Quote quote)
        {
            List<QuoteRow> quoteRowsList = new List<QuoteRow>();

            try
            {
                _database.setQuery("select R.QuoteRowId, R.RowIndex, W.Amount, W.RowDescription, W.Price, W.ProductId, W.ServiceId from QuoteRowQuoteRelations R inner join Quotes Q on Q.QuoteId = R.QuoteId inner join QuoteRows W on W.QuoteRowId = R.QuoteRowId where R.QuoteId = @QuoteId");
                _database.setParameter("@QuoteId", quote.QuoteId);
                _database.executeReader();

                while (_database.Reader.Read())
                {
                    QuoteRow quoteRow = new QuoteRow();

                    quoteRow.QuoteRowId = (int)_database.Reader["QuoteRowId"];
                    quoteRow.Index = Convert.ToInt32(_database.Reader["RowIndex"]);
                    quoteRow.Amount = Convert.ToInt32(_database.Reader["Amount"]);
                    quoteRow.Description = (string)_database.Reader["RowDescription"];
                    quoteRow.Price = (decimal)_database.Reader["Price"];

                    if (!(_database.Reader["ProductId"] is DBNull))
                    {
                        quoteRow.Product.ProductId = (int)_database.Reader["ProductId"];
                    }

                    if (!(_database.Reader["ServiceId"] is DBNull))
                    {
                        quoteRow.Service.ServiceId = (int)_database.Reader["ServiceId"];
                    }

                    quoteRowsList.Add(quoteRow);
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

            foreach (QuoteRow quoteRow in quoteRowsList)
            {
                quoteRow.Product = _productsManager.read(quoteRow.Product.ProductId);
                quoteRow.Service = _servicesManager.read(quoteRow.Service.ServiceId);
            }

            return quoteRowsList;
        }

        public void delete(Quote quote)
        {
            try
            {
                _database.setQuery("delete from Quotes where QuoteId = @QuoteId");
                _database.setParameter("@QuoteId", quote.QuoteId);
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
