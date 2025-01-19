using DomainModel;
using Exceptions;
using System;
using Utilities;

namespace DataAccess
{
    public class AddressesDAL
    {
        private Database _db;

        public AddressesDAL(Database db)
        {
            _db = db;
        }

        public int Create(Address address)
        {
            try
            {
                _db.SetProcedure("sp_create_address");
                SetParameters(address);
                address.Id = _db.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ex);
            }
            finally
            {
                _db.CloseConnection();
            }

            return address.Id;
        }

        public Address Read(int addressId)
        {
            try
            {
                _db.SetQuery("select * from addresses where address_id = @address_id");
                _db.SetParameter("@address_id", addressId);
                _db.ExecuteRead();

                if (_db.Reader.Read())
                {
                    Address address = new Address();
                    ReadRow(address);
                    return address;
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

        private void SetParameters(Address address, bool isUpdate = false)
        {
            if (isUpdate)
            {
                _db.SetParameter("@address_id", address.Id);
            }

            _db.SetParameter("@street_name", address.StreetName);
            _db.SetParameter("@street_number", address.StreetNumber);

            if (address.Flat != null)
            {
                _db.SetParameter("@flat", address.Flat);
            }
            else
            {
                _db.SetParameter("@flat", DBNull.Value);
            }

            if (address.Details != null)
            {
                _db.SetParameter("@details", address.Details);
            }
            else
            {
                _db.SetParameter("@details", DBNull.Value);
            }

            _db.SetParameter("@city_id", address.City.Id);
        }

        private void ReadRow(Address address)
        {
            address.Id = Convert.ToInt32(_db.Reader["address_id"]);
            address.StreetName = _db.Reader["street_name"].ToString();
            address.StreetNumber = _db.Reader["street_number"].ToString();
            address.Flat = _db.Reader["flat"]?.ToString();
            address.Details = _db.Reader["details"]?.ToString();
            address.City = Helper.Instantiate<City>(_db.Reader["city_id"]);
        }
    }
}
