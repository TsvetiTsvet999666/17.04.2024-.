namespace ListOfEmployees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();
            for (int i = 0; i < n; i++)
            {
                string[] employeeInfo = Console.ReadLine().Split();
                string name = employeeInfo[0];
                decimal salary = decimal.Parse(employeeInfo[1]);
                string position = employeeInfo[2];
                string department = employeeInfo[3];
                string email = employeeInfo.Length > 4 ? employeeInfo[4] : null;
                int age = employeeInfo.Length > 5 ? int.Parse(employeeInfo[5]) : -1;
                Employee employee = new Employee(name, salary, position, department, email, age);
                employees.Add(employee);
            }
            var highestSalaryDepartment = employees
                .GroupBy(e => e.Department)
                .Select(g => new { Department = g.Key, AverageSalary = g.Average(e => e.Salary) })
                .OrderByDescending(g => g.AverageSalary)
                .First()
                .Department;
            var employeesFromHighestSalaryDepartment = employees
                .Where(e => e.Department == highestSalaryDepartment)
                .OrderByDescending(e => e.Salary);
            foreach (var employee in employeesFromHighestSalaryDepartment)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
