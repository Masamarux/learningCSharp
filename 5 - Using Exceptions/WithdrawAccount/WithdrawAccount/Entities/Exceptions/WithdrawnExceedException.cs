using System;
using System.Collections.Generic;
using System.Text;

namespace WithdrawAccount.Entities.Exceptions
{
    class WithdrawnExceedException : ApplicationException
    {
        public WithdrawnExceedException(string message) : base(message)
        {
        }
    }
}
