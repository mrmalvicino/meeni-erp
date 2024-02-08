using DAL;
using Entities;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class PositionsManager
    {
        // ATTRIBUTES

        private Database _database = new Database();

        // METHODS

        public List<Position> list()
        {
            List<Position> list = new List<Position>();

            try
            {
                _database.setQuery("SELECT Id, Area, Title, Seniority FROM positions");
                _database.executeReader();

                while (_database.Reader.Read())
                {
                    Position position = new Position();

                    position.PositionId = (int)_database.Reader["Id"];
                    position.Title = (string)_database.Reader["Title"];
                    position.Seniority.Name = (string)_database.Reader["Seniority"];
                    position.Department.Name = (string)_database.Reader["Area"];

                    list.Add(position);
                }

                return list;
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

        public List<string> list(string attribute)
        {
            List<string> list = new List<string>();

            try
            {
                _database.setQuery($"SELECT {attribute} FROM positions");
                _database.executeReader();

                while (_database.Reader.Read())
                {
                    string str = (string)_database.Reader[$"{attribute}"];

                    if (!list.Contains(str))
                        list.Add(str);
                }

                return list;
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

        public void add(Position position)
        {
            try
            {
                _database.setQuery("INSERT INTO positions (Area, Title, Seniority) VALUES (@Area, @Title, @Seniority)");
                _database.setParameter("@Title", position.Title);
                _database.setParameter("@Seniority", position.Seniority.Name);
                _database.setParameter("@Area", position.Department.Name);
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

        public void edit(Position position)
        {
            try
            {
                _database.setQuery("UPDATE positions SET Area = @Area, Title = @Title, Seniority = @Seniority WHERE Id = @Id");
                _database.setParameter("@Id", position.PositionId);
                _database.setParameter("@Title", position.Title);
                _database.setParameter("@Seniority", position.Seniority.Name);
                _database.setParameter("@Area", position.Department.Name);
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

        public void delete(int id)
        {
            try
            {
                _database.setQuery("DELETE FROM positions WHERE Id = @Id");
                _database.setParameter("@Id", id);
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
        
        public int getPositionId(string department, string title, string seniority)
        {
            foreach (Position position in list())
            {
                if (position.Department.Name == department && position.Title == title && position.Seniority.Name == seniority)
                    return position.PositionId;
            }

            return -1;
        }
    }
}
