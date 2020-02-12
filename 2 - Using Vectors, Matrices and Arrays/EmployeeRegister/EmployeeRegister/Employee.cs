using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace EmployeeRegister {
    class Employee {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public double Salary { get; private set; }

        public Employee(int id, string name, double salary) {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double percentage) {
            Salary += (Salary * percentage) / 100;
        }

        public override string ToString() {
            return  Id
                    + ", "
                    + Name
                    + ", R$ "
                    + Salary.ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
