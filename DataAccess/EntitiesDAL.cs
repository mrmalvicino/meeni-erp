using DomainModel;
using Exceptions;
using Utilities;
using System;

namespace DataAccess
{
    public class EntitiesDAL
    {
        private Database _db;

        public EntitiesDAL(Database db)
        {
            _db = db;
        }

        public int Create(Entity legalEntity)
        {
            try
            {
                _db.SetProcedure("sp_create_legal_entity");
                SetParameters(legalEntity);
                legalEntity.Id = _db.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ex);
            }
            finally
            {
                _db.CloseConnection();
            }

            return legalEntity.Id;
        }

        public Entity Read(int legalEntityId)
        {
            try
            {
                _db.SetQuery("select * from legal_entities where legal_entity_id = @legal_entity_id");
                _db.SetParameter("@legal_entity_id", legalEntityId);
                _db.ExecuteRead();

                if (_db.Reader.Read())
                {
                    Entity legalEntity = new Entity();
                    ReadRow(legalEntity);
                    return legalEntity;
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

        public void Update(Entity legalEntity)
        {
            try
            {
                _db.SetProcedure("sp_update_legal_entity");
                SetParameters(legalEntity, true);
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

        private void SetParameters(Entity legalEntity, bool isUpdate = false)
        {
            if (isUpdate)
            {
                _db.SetParameter("@legal_entity_id", legalEntity.Id);
            }

            if (!string.IsNullOrEmpty(legalEntity.CUIT))
            {
                _db.SetParameter("@cuit", legalEntity.CUIT);
            }
            else
            {
                _db.SetParameter("@cuit", DBNull.Value);
            }

            _db.SetParameter("@legal_entity_name", legalEntity.Name);

            if (!string.IsNullOrEmpty(legalEntity.Email))
            {
                _db.SetParameter("@email", legalEntity.Email);
            }
            else
            {
                _db.SetParameter("@email", DBNull.Value);
            }

            if (!string.IsNullOrEmpty(legalEntity.Phone))
            {
                _db.SetParameter("@phone", legalEntity.Phone);
            }
            else
            {
                _db.SetParameter("@phone", DBNull.Value);
            }

            if (legalEntity.LogoImage != null)
            {
                _db.SetParameter("@logo_image_id", legalEntity.LogoImage.Id);
            }
            else
            {
                _db.SetParameter("@logo_image_id", DBNull.Value);
            }

            if (legalEntity.Address != null)
            {
                _db.SetParameter("@address_id", legalEntity.Address.Id);
            }
            else
            {
                _db.SetParameter("@address_id", DBNull.Value);
            }
        }

        private void ReadRow(Entity legalEntity)
        {
            legalEntity.Id = Convert.ToInt32(_db.Reader["legal_entity_id"]);
            legalEntity.CUIT = _db.Reader["cuit"]?.ToString();
            legalEntity.Name = _db.Reader["legal_entity_name"].ToString();
            legalEntity.Email = _db.Reader["email"]?.ToString();
            legalEntity.Phone = _db.Reader["phone"]?.ToString();
            legalEntity.LogoImage = Helper.Instantiate<Image>(_db.Reader["logo_image_id"]);
            legalEntity.Address = Helper.Instantiate<Address>(_db.Reader["address_id"]);
        }
    }
}
