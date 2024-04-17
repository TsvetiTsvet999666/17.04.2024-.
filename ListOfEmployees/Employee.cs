using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfEmployees
{
    public class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public Employee(string name, decimal salary, string position, string department, string email, int age)
        {
            Name = name;
            Salary = salary;
            Position = position;
            Department = department;
            Email = email;
            Age = age;
        }
        public override string ToString()
        {
            string email = string.IsNullOrEmpty(Email) ? "n/a" : Email;
            string age = Age <= 0 ? "-1" : Age.ToString();
            return $"{Name} {Salary:F2} {Position} {Department} {email} {age}";
        }
    }
}
