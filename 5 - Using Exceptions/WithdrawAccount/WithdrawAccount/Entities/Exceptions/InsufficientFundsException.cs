using System;
using System.Collections.Generic;
using System.Text;

namespace WithdrawAccount.Entities.Exceptions
{
    class InsufficientFundsException : ApplicationException
    {
        public InsufficientFundsException(string message) : base(message)
        {
        }
    }
}
