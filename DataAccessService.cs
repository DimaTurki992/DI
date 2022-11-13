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

            // property injection
            new Employee()
            {
                Id = 2,
                FirstName = "Kevin",
                LastName = "Marshall",
                Logger = logger
            },

            // dependency to be injected using Method Injection
            new Employee()
            {
                Id = 3,
                FirstName = "Test1",
                LastName = "Test2"
            }
        };

        public List<Employee> GetAll()
        {
            return Employees;
        }

        public Employee Get(int id)
        {
            return Employees.Find(e => e.Id == id);
        }

        public Employee Add(Employee data)
        {
            Employees.Add(data);
            return data;
        }
    }
}
