using System.Collections.Generic;

namespace DIP
{
    public class DataAccessService : IDataAccessService
    {
        private static List<Employee> Employees = new List<Employee>()
        {
            new Employee()
            {
                Id = 1,
                FirstName = "Dima",
                LastName = "Turki"
            },

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
