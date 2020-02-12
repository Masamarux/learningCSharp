using System;
using System.Collections.Generic;
using System.Globalization;

namespace EmployeeRegister {
    class Program {
        static void Main(string[] args) {
            int manyEmployees, id, idSearch;
            string name;
            double salary;
            List<Employee> listEmployees = new List<Employee>();

            Console.Write("How many employees will be registered? ");
            manyEmployees = int.Parse(Console.ReadLine());

            for(int i = 0; i < manyEmployees; i++) {
                Console.WriteLine($"Employee #{i+1}:");

                Console.Write("Id: ");
                id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                name = Console.ReadLine();

                Console.Write("Salary: ");
                salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Employee emp = new Employee(id, name, salary);
                listEmployees.Add(emp);
                Console.WriteLine();//breakline
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            idSearch = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            FindAndIncreaseSalary(listEmployees, idSearch);

            Console.WriteLine();
            Console.WriteLine("Updated list of employees: ");
            foreach (Employee employee in listEmployees) {
                Console.WriteLine(employee);
            }


        }

        static void FindAndIncreaseSalary(List<Employee> listEmployees, int idSearch ) {
            if (listEmployees.Exists(x => x.Id == idSearch)) {
                int indexOf;
                double percentage;

                indexOf = listEmployees.FindIndex(x => x.Id == idSearch);

                Console.Write("Enter the percentage: ");
                percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                listEmployees[indexOf].IncreaseSalary(percentage);
            }
            else {
                Console.WriteLine("This id not exists!");
            }
        }
    }
}
