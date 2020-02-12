using System;
using System.Globalization;
using WithdrawAccount.Entities;
using WithdrawAccount.Entities.Exceptions;

namespace WithdrawAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            string holder;
            double iniBalance, withdrawnLimt, ammount;

            Account acc;

            Console.WriteLine("Enter account data: ");
            Console.Write("Number: ");
            number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            iniBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Withdraw limit: ");
            withdrawnLimt = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            acc = new Account(number, holder, iniBalance, withdrawnLimt);

            Console.WriteLine();
            Console.Write("Enter amount for withdraw: ");
            ammount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            try
            {
                acc.Withdraw(ammount);
            }
            catch (WithdrawnExceedException e)
            {
                Console.WriteLine("Error with your withdraw: " + e.Message);
            }
            catch (InsufficientFundsException e)
            {
                Console.WriteLine("Error with your funds: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Account balance now: $" + acc.Balance.ToString("f2", CultureInfo.InvariantCulture));
            }
        }
    }
}
