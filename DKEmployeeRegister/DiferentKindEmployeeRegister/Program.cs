using System;
using System.Collections.Generic;
using System.Globalization;
using DiferentKindEmployeeRegister.Entities;

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

            List<Employee> employeeList = new List<Employee>();
            Employee employee;

            Console.Write("Enter the number of employees: ");
            nEmployees = int.Parse(Console.ReadLine());
            for(int i = 0; i < nEmployees; i++)
            {
                outsourced = ' ';
                name = "";
                hours = 0;
                valuePerHour = 0.00;
                Console.WriteLine($"Employee #{i+1} data:");
                Console.Write("Outsourced (y/n)? ");
                outsourced = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Hours: ");
                hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (outsourced == 'y' || outsourced == 'Y')
                {
                    Console.Write("Additional charge: ");
                    additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    employeeList.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    employeeList.Add(new Employee(name, hours, valuePerHour));
                }
            }
            Console.WriteLine("PAYMENTS: ");
            foreach(Employee emp in employeeList)
            {
                Console.WriteLine(emp.Name + " - R$ " + emp.Payment());
            }
        }
    }
}
