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

        public int Create(Entity entity)
        {
            try
            {
                _db.SetProcedure("sp_create_entity");
                SetParameters(entity);
                entity.Id = _db.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ex);
            }
            finally
            {
                _db.CloseConnection();
            }

            return entity.Id;
        }

        public Entity Read(int entityId)
        {
            try
            {
                _db.SetQuery("select * from entities where entity_id = @entity_id");
                _db.SetParameter("@entity_id", entityId);
                _db.ExecuteRead();

                if (_db.Reader.Read())
                {
                    Entity entity = new Entity();
                    ReadRow(entity);
                    return entity;
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

        public void Update(Entity entity)
        {
            try
            {
                _db.SetProcedure("sp_update_entity");
                SetParameters(entity, true);
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

        public int FindOrganizationId(int entityId)
        {
            try
            {
                _db.SetProcedure("sp_find_entity_organization_id");
                _db.SetParameter("@entity_id", entityId);
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

        private void SetParameters(Entity entity, bool isUpdate = false)
        {
            if (isUpdate)
            {
                _db.SetParameter("@entity_id", entity.Id);
            }

            _db.SetParameter("@name", entity.Name);
            _db.SetParameter("@is_organization", entity.IsOrganization);

            if (!string.IsNullOrEmpty(entity.Email))
            {
                _db.SetParameter("@email", entity.Email);
            }
            else
            {
                _db.SetParameter("@email", DBNull.Value);
            }

            if (!string.IsNullOrEmpty(entity.Phone))
            {
                _db.SetParameter("@phone", entity.Phone);
            }
            else
            {
                _db.SetParameter("@phone", DBNull.Value);
            }

            if (entity.BirthDate != null && entity.BirthDate != DateTime.MinValue)
            {
                _db.SetParameter("@birth_date", entity.BirthDate);
            }
            else
            {
                _db.SetParameter("@birth_date", DBNull.Value);
            }

            if (entity.Image != null)
            {
                _db.SetParameter("@image_id", entity.Image.Id);
            }
            else
            {
                _db.SetParameter("@image_id", DBNull.Value);
            }

            if (entity.Address != null)
            {
                _db.SetParameter("@address_id", entity.Address.Id);
            }
            else
            {
                _db.SetParameter("@address_id", DBNull.Value);
            }

            if (entity.Identification != null)
            {
                _db.SetParameter("@identification_id", entity.Identification.Id);
            }
            else
            {
                _db.SetParameter("@identification_id", DBNull.Value);
            }
        }

        private void ReadRow(Entity entity)
        {
            entity.Id = Convert.ToInt32(_db.Reader["entity_id"]);
            entity.Name = _db.Reader["name"].ToString();
            entity.IsOrganization = Convert.ToBoolean(_db.Reader["is_organization"]);
            entity.Email = _db.Reader["email"]?.ToString();
            entity.Phone = _db.Reader["phone"]?.ToString();
            entity.BirthDate = _db.Reader["birth_date"] as DateTime? ?? entity.BirthDate;
            entity.Image = Helper.Instantiate<Image>(_db.Reader["image_id"]);
            entity.Address = Helper.Instantiate<Address>(_db.Reader["address_id"]);
            entity.Identification = Helper.Instantiate<Identification>(_db.Reader["identification_id"]);
        }
    }
}
