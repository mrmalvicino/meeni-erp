using DomainModel.Base;
using Exceptions;
using System;
using System.Collections.Generic;

namespace DataAccess.Base
{
    public class IdentificationTypesDAL
    {
        private Database _db;

        public IdentificationTypesDAL(Database db)
        {
            _db = db;
        }

        public IdentificationType Read(int identificationTypeId)
        {
            try
            {
                _db.SetProcedure("sp_read_identification_type");
                _db.SetParameter("@identification_type_id", identificationTypeId);
                _db.ExecuteRead();

                if (_db.Reader.Read())
                {
                    IdentificationType identificationType = new IdentificationType();
                    ReadRow(identificationType);
                    return identificationType;
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

        public List<IdentificationType> List()
        {
            List<IdentificationType> identificationTypes = new List<IdentificationType>();

            try
            {
                _db.SetProcedure("sp_list_identification_types");
                _db.ExecuteRead();

                while (_db.Reader.Read())
                {
                    IdentificationType identificationType = new IdentificationType();
                    ReadRow(identificationType);
                    identificationTypes.Add(identificationType);
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

            return identificationTypes;
        }

        private void ReadRow(IdentificationType identificationType)
        {
            identificationType.Id = Convert.ToInt32(_db.Reader["identification_type_id"]);
            identificationType.Name = _db.Reader["name"].ToString();
        }
    }
}
