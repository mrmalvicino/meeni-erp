using System;

namespace Exceptions
{
    public class DatabaseQueryException : Exception
    {
        private const string DEFAULT_MESSAGE = "Ocurrió un error en la clase Database de la capa de acceso a datos.";

        public DatabaseQueryException()
            : base(DEFAULT_MESSAGE)
        {

        }

        public DatabaseQueryException(string message)
            : base(message)
        {

        }

        public DatabaseQueryException(Exception innerException)
            : base(DEFAULT_MESSAGE, innerException)
        {

        }

        public DatabaseQueryException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
