using System;

namespace Exceptions
{
    public class DatabaseQueryException : DataAccessException
    {
        private const string _defaultMessage = "Ocurrió un error en la clase Database de la capa de acceso a datos.";

        public DatabaseQueryException()
            : base(_defaultMessage)
        {

        }

        public DatabaseQueryException(string message)
            : base(message)
        {

        }

        public DatabaseQueryException(Exception innerException)
            : base(_defaultMessage, innerException)
        {

        }

        public DatabaseQueryException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
