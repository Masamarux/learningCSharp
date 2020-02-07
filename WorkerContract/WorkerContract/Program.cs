using System;
using System.Globalization;
using WorkerContract.Entities;
using WorkerContract.Entities.Enums;

namespace WorkerContract
{
    class Program
    {
        static void Main(string[] args)
        {
            int manyWorkers, contractHours, month, year;
            string department, name, monthYearIncome;
            double baseSalary, valuePerH;
            WorkerLevel level;
            DateTime date;

            Console.WriteLine("Enter department's name: ");
            department = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Level (Junior / MidLevel / Senior): ");
            level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("How many contracts to this worker? ");
            manyWorkers = int.Parse(Console.ReadLine());

            Department dept = new Department(department);
            Worker worker = new Worker(name, level, baseSalary, dept);

            for(int i = 0; i < manyWorkers; i++)
            {
                Console.WriteLine($"Enter #{i+1} contract data: ");
                Console.Write("Date(DD/MM/YYYY): ");
                date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                valuePerH = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                contractHours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerH, contractHours);

                worker.AddContract(contract);
            }
            Console.WriteLine();
            Console.WriteLine("Enter month and year to calculate income (MM/YYYY): ");
            monthYearIncome = Console.ReadLine();
            month = int.Parse(monthYearIncome.Substring(0, 2));
            year = int.Parse(monthYearIncome.Substring(3));
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for " + monthYearIncome + ": " + worker.Income(year, month).ToString("f2", CultureInfo.InvariantCulture));


        }
    }
}
