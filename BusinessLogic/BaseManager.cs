using Exceptions;
using Interfaces;
using System;

namespace BusinessLogic
{
    public abstract class BaseManager<T>
        where T : IIdentifiable
    {
        protected void HandleAttribute(T attribute)
        {
            try
            {
                if (attribute != null)
                {
                    int foundId = FindId(attribute);

                    if (foundId == 0)
                    {
                        attribute.Id = Create(attribute);
                    }
                    else if (foundId == attribute.Id)
                    {
                        Update(attribute);
                    }
                    else
                    {
                        attribute.Id = foundId;
                        Update(attribute);
                    }
                }
            }
            catch (Exception ex) when (!(ex is ValidationException))
            {
                throw new BusinessLogicException(ex);
            }
        }

        protected abstract int Create(T attribute);
        protected abstract void Update(T attribute);
        protected abstract int FindId(T attribute);
    }
}
