using System;

namespace Exceptions
{
    public class TransactionScopeException : BusinessLogicException
    {
        private const string _defaultMessage = "Ocurrió un error de transacción y las operaciones fueron revertidas.";

        public TransactionScopeException()
            : base(_defaultMessage)
        {

        }

        public TransactionScopeException(string message)
            : base(message)
        {

        }

        public TransactionScopeException(Exception innerException)
            : base(_defaultMessage, innerException)
        {

        }

        public TransactionScopeException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
