using WithdrawAccount.Entities.Exceptions;

namespace WithdrawAccount.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if(amount > WithdrawLimit)
            {
                throw new WithdrawnExceedException("Please, check your withdraw limit.");
            }
            else
            {
                if(amount > Balance)
                {
                    throw new InsufficientFundsException("Please, check your balance before withdraw.");
                }
                else
                {
                    Balance -= amount;
                }
            }
        }
    }
}
