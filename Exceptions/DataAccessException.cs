using System;

namespace Exceptions
{
    public class DataAccessException : Exception
    {
        private const string DEFAULT_MESSAGE = "Ocurrió un error en la capa de acceso a datos.";

        public DataAccessException()
            : base(DEFAULT_MESSAGE)
        {

        }

        public DataAccessException(string message)
            : base(message)
        {

        }

        public DataAccessException(Exception innerException)
            : base(DEFAULT_MESSAGE, innerException)
        {

        }

        public DataAccessException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
