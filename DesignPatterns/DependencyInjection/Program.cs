using System;

namespace DependencyInjection
{
    class Program
    {
        static public EmployeeBAL employeeBAL;
        static void Main(string[] args)
        {
            employeeBAL = new EmployeeBAL(new EmployeeDAL());
            foreach (Employee employee in employeeBAL.AllEmployees())
            {
                Console.WriteLine("ID={0}, Name={1}, Email={2}",employee.Id, employee.Name, employee.Email);
            }
        }
    }
}
