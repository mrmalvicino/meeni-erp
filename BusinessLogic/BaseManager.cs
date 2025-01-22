using Exceptions;
using Interfaces;
using System;
using System.Transactions;

namespace BusinessLogic
{
    public abstract class BaseManager<T>
        where T : IIdentifiable
    {
        protected void HandleEntity(T entity)
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
            catch (Exception ex) when (!(ex is ValidationException))
            {
                throw new BusinessLogicException(ex);
            }
        }

        protected abstract int Create(T entity);
        protected abstract void Update(T entity);
        protected abstract int FindId(T entity);
    }
}
