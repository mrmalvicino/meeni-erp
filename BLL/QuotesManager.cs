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

        // METHODS

        public List<Quote> list()
        {
            List<Quote> quotesList = new List<Quote>();

            try
            {
                _database.setQuery("select QuoteId, ActiveStatus, QuoteName, AdressId from Quotes");
                _database.executeReader();

                while (_database.Reader.Read())
                {
                    Quote quote = new Quote();

                    quote.QuoteId = (int)_database.Reader["QuoteId"];
                    quote.ActiveStatus = (bool)_database.Reader["ActiveStatus"];
                    quote.Name = (string)_database.Reader["QuoteName"];
                    quote.Adress.AdressId = (int)_database.Reader["AdressId"];

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
                quote.Adress = _adressesManager.read(quote.Adress.AdressId);
            }

            return quotesList;
        }

        public Quote read(int quoteId)
        {
            Quote quote = new Quote();

            try
            {
                _database.setQuery("select ActiveStatus, QuoteName, AdressId from Quotes where QuoteId = @QuoteId");
                _database.setParameter("@QuoteId", quoteId);
                _database.executeReader();

                if (_database.Reader.Read())
                {
                    quote.QuoteId = quoteId;
                    quote.ActiveStatus = (bool)_database.Reader["ActiveStatus"];
                    quote.Name = (string)_database.Reader["QuoteName"];
                    quote.Adress.AdressId = (int)_database.Reader["AdressId"];
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

            quote.Adress = _adressesManager.read(quote.Adress.AdressId);

            return quote;
        }

        public void add(Quote quote)
        {
            int dbAdressId = _adressesManager.getId(quote.Adress);

            if (dbAdressId == 0)
            {
                _adressesManager.add(quote.Adress);
                quote.Adress.AdressId = Helper.getLastId("Adresses");
            }
            else
            {
                quote.Adress.AdressId = dbAdressId;
            }

            try
            {
                _database.setQuery("insert into Quotes (ActiveStatus, QuoteName, AdressId) values (@ActiveStatus, @QuoteName, @AdressId)");
                setParameters(quote);
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

        public void edit(Quote quote)
        {
            int dbAdressId = _adressesManager.getId(quote.Adress);

            if (dbAdressId == 0)
            {
                _adressesManager.add(quote.Adress);
                quote.Adress.AdressId = Helper.getLastId("Adresses");
            }
            else if (dbAdressId == quote.Adress.AdressId)
            {
                _adressesManager.edit(quote.Adress);
            }
            else
            {
                quote.Adress.AdressId = dbAdressId;
            }

            try
            {
                _database.setQuery("update Quotes set ActiveStatus = @ActiveStatus, QuoteName = @QuoteName, AdressId = @AdressId where QuoteId = @QuoteId");
                _database.setParameter("@QuoteId", quote.QuoteId);
                setParameters(quote);
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

        private void setParameters(Quote quote)
        {
            _database.setParameter("@ActiveStatus", quote.ActiveStatus);
            _database.setParameter("@QuoteName", quote.Name);
            _database.setParameter("@AdressId", quote.Adress.AdressId);
        }
    }
}
