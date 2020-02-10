using System;

namespace DiferentKindEmployeeRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            int nEmployees, hours;
            char outsourced;
            string name;
            double valuePerHour, additionalCharge;

            Console.WriteLine("Enter the number of employees: ");
            nEmployees = int.Parse(Console.ReadLine());
            for(int i = 0; i < nEmployees; i++)
            {
                outsourced = ' ';
                Console.WriteLine($"Employee #{i} data:");
                Console.WriteLine("Outsourced (y/n)? ");
                outsourced = char.Parse(Console.ReadLine());
                if(outsourced == 'y' || outsourced == 'Y')
                {
                    Console.WriteLine("Name: ");
                    name = Console.ReadLine();
                    Console.WriteLine("Hours: ");
                    hours = int.Parse(Console.ReadLine());
                    Console.WriteLine("Value per hour:");
                    valuePerHour = double.Parse(Console.ReadLine());

                }

            }
        }
    }
}
