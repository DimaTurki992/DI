using System.Collections.Generic;

namespace DIP
{
    public class DataAccessService : IDataAccessService
    {
        static Logger logger = new Logger();
        private static List<Employee> Employees = new List<Employee>()
        {
            // constructor injection
            new Employee(logger)
            {
                Id = 1,
                FirstName = "Dima",
                LastName = "Turki"
            },

            // dependency to be injected using Method Injection
            new Employee()
            {
                Id = 2,
                FirstName = "Test1",
                LastName = "Test2"
            }
        };

        public List<Employee> GetAllEmployees()
        {
            return Employees;
        }

        public Employee GetEmployeeById(int id)
        {
            return Employees.Find(e => e.Id == id);
        }

        public Employee AddEmployee(Employee data)
        {
            Employees.Add(data);
            return data;
        }
    }
}
