namespace DependencyInjection
{
    public class EmployeeDAL : IEmployeeDAL //Service class must implement interface
    {
        public List<Employee> GetAllEmployees()
        {
            List<Employee> Employees = new List<Employee>();
            Employees.Add(new Employee(){ Id=1, Name="Sujon", Email="s.c.shil94@gmil.com" });
            Employees.Add(new Employee(){ Id=2, Name="Chondro", Email="chondro@gmil.com" });
            Employees.Add(new Employee(){ Id=3, Name="Shil", Email="shil@gmil.com" });
            Employees.Add(new Employee(){ Id=4, Name="Rajesh", Email="rajesh@gmil.com" });

            return Employees;
        }
    }
}