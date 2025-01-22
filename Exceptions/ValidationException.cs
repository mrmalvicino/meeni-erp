using System;

namespace Exceptions
{
    public class ValidationException : Exception
    {
        private const string DEFAULT_MESSAGE = "Error de validación.";

        public ValidationException()
            : base(DEFAULT_MESSAGE)
        {

        }

        public ValidationException(string message)
            : base(message)
        {

        }

        public ValidationException(Exception innerException)
            : base(DEFAULT_MESSAGE, innerException)
        {

        }

        public ValidationException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}