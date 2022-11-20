using System.Collections.Generic;

namespace DIP
{
    public interface IDataAccessService
    {
        List<Employee> GetAllEmployees();
        Employee GetEmployeeById(int id);
        Employee AddEmployee(Employee data);
    }
}
