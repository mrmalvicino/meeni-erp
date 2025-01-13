using System;

namespace Exceptions
{
    public class DataAccessException : Exception
    {
        private const string _defaultMessage = "Ocurrió un error en la capa de acceso a datos.";

        public DataAccessException()
            : base(_defaultMessage)
        {

        }

        public DataAccessException(string message)
            : base(message)
        {

        }

        public DataAccessException(Exception innerException)
            : base(_defaultMessage, innerException)
        {

        }

        public DataAccessException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
