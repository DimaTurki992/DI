using System.Collections.Generic;

namespace DIP
{
    public interface IDataAccessService
    {
        List<Employee> GetAll();
        Employee Get(int id);
        Employee Add(Employee data);
    }
}
