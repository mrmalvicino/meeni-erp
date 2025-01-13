using System;

namespace Exceptions
{
    public class BusinessLogicException : Exception
    {
        private const string _defaultMessage = "Ocurrió un error en la capa de lógica de negocio.";

        public BusinessLogicException()
            : base(_defaultMessage)
        {

        }

        public BusinessLogicException(string message)
            : base(message)
        {

        }

        public BusinessLogicException(Exception innerException)
            : base(_defaultMessage, innerException)
        {

        }

        public BusinessLogicException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
