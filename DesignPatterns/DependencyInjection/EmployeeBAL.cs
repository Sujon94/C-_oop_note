namespace DependencyInjection
{
    public class EmployeeBAL
    {
        public IEmployeeDAL employeeDAL;

         //Injecting object through constructor, using interface. This is
         // called Constructor Injection
        public EmployeeBAL(IEmployeeDAL employeeDAL)   
        {
            this.employeeDAL = employeeDAL;
        }
        
        public List<Employee> AllEmployees()
        {
            return employeeDAL.GetAllEmployees();
        }
    }
}