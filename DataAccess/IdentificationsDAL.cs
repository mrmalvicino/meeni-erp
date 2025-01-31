using DomainModel;
using Exceptions;
using System;
using Utilities;

namespace DataAccess
{
    public class IdentificationsDAL
    {
        private Database _db;

        public IdentificationsDAL(Database db)
        {
            _db = db;
        }

        public int Create(Identification identification)
        {
            try
            {
                _db.SetProcedure("sp_create_identification");
                SetParameters(identification);
                identification.Id = _db.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ex);
            }
            finally
            {
                _db.CloseConnection();
            }

            return identification.Id;
        }

        public Identification Read(int identificationId)
        {
            try
            {
                _db.SetQuery("select * from identifications where identification_id = @identification_id");
                _db.SetParameter("@identification_id", identificationId);
                _db.ExecuteRead();

                if (_db.Reader.Read())
                {
                    Identification identification = new Identification();
                    ReadRow(identification);
                    return identification;
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

        public void Update(Identification identification)
        {
            try
            {
                _db.SetProcedure("sp_update_identification");
                SetParameters(identification, true);
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

        public int FindId(Identification identification, int organizationId)
        {
            try
            {
                _db.SetProcedure("sp_find_identification_id");
                _db.SetParameter("@code", identification.Code);
                _db.SetParameter("@organization_id", organizationId);
                _db.ExecuteRead();

                if (_db.Reader.Read())
                {
                    return (int)_db.Reader["identification_id"];
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

        private void SetParameters(Identification identification, bool isUpdate = false)
        {
            if (isUpdate)
            {
                _db.SetParameter("@identification_id", identification.Id);
            }

            _db.SetParameter("@code", identification.Code);
            _db.SetParameter("@identification_type_id", Helper.GetId(identification.IdentificationType));
        }

        private void ReadRow(Identification identification)
        {
            identification.Id = Convert.ToInt32(_db.Reader["identification_id"]);
            identification.Code = _db.Reader["code"].ToString();
            identification.IdentificationType = Helper.Instantiate<IdentificationType>(_db.Reader["identification_type_id"]);
        }
    }
}
