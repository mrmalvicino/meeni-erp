﻿using Exceptions;
using Interfaces;
using System;

namespace BusinessLogic
{
    public abstract class BaseManager<T>
        where T : IIdentifiable
    {
        public void HandleEntity(T entity)
        {
            try
            {
                if (entity != null)
                {
                    int foundId = FindId(entity);

                    if (foundId == 0)
                    {
                        entity.Id = Create(entity);
                    }
                    else if (foundId == entity.Id)
                    {
                        Update(entity);
                    }
                    else
                    {
                        entity.Id = foundId;
                        Update(entity);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ex);
            }
        }

        protected abstract int Create(T entity);
        protected abstract void Update(T entity);
        protected abstract int FindId(T entity);
    }
}
