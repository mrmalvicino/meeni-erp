using System;

namespace Exceptions
{
    public class BusinessLogicException : Exception
    {
        private const string DEFAULT_MESSAGE = "Ocurrió un error en la capa de lógica de negocio.";

        public BusinessLogicException()
            : base(DEFAULT_MESSAGE)
        {

        }

        public BusinessLogicException(string message)
            : base(message)
        {

        }

        public BusinessLogicException(Exception innerException)
            : base(DEFAULT_MESSAGE, innerException)
        {

        }

        public BusinessLogicException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
