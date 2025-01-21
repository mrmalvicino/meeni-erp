using System;

namespace Exceptions
{
    public class ValidationException : Exception
    {
        private const string _defaultMessage = "Error de validación.";

        public ValidationException()
            : base(_defaultMessage)
        {

        }

        public ValidationException(string message)
            : base(message)
        {

        }

        public ValidationException(Exception innerException)
            : base(_defaultMessage, innerException)
        {

        }

        public ValidationException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}