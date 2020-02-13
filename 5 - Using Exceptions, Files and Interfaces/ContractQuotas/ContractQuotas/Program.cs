using System;
using System.Globalization;
using ContractQuotas.Entities;
using ContractQuotas.Services;

namespace ContractQuotas
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, nInstallments;
            double value;
            DateTime date;

            Contract contract;


            Console.WriteLine("Enter contract data:");
            Console.Write("Number: ");
            number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            date = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: ");
            value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            nInstallments = int.Parse(Console.ReadLine());

            contract = new Contract(number, date, value, new PaypalQuota());
            contract.CreateInstallments(nInstallments);
            Console.WriteLine("\nInstallments: ");
            Console.WriteLine(contract.ShowInstallments());
        }
    }
}
