using System;

namespace Exceptions
{
    public class TransactionScopeException : Exception
    {
        private const string DEFAULT_MESSAGE = "Ocurrió un error de transacción y las operaciones fueron revertidas.";

        public TransactionScopeException()
            : base(DEFAULT_MESSAGE)
        {

        }

        public TransactionScopeException(string message)
            : base(message)
        {

        }

        public TransactionScopeException(Exception innerException)
            : base(DEFAULT_MESSAGE, innerException)
        {

        }

        public TransactionScopeException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
