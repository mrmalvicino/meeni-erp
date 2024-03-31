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

        public Quote read(int quoteId)
        {
            Quote quote = new Quote();

            try
            {
                _database.setQuery("select QuoteId, ActiveStatus, VariantVersion, JobDate, CustomerId from Quotes where QuoteId = @QuoteId");
                _database.setParameter("@QuoteId", quoteId);
                _database.executeReader();

                if (_database.Reader.Read())
                {
                    quote.QuoteId = (int)_database.Reader["QuoteId"];
                    quote.ActiveStatus = (string)_database.Reader["ActiveStatus"];
                    quote.VariantVersion = Convert.ToInt32(_database.Reader["VariantVersion"]);
                    quote.JobDate = (DateTime)_database.Reader["JobDate"];
                    quote.Customer.CustomerId = (int)_database.Reader["CustomerId"];
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

            return quote;
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
