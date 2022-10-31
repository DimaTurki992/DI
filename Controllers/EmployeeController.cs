using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DIP.Controllers
{
    [Route("/api/employee")]
    [ApiController]
    public class EmployeeController : Controller
    {
        public EmployeeController()
        {

        }

        [HttpGet()]
        public void PrintEmployeeInfo()
        {
            Logger logger = new Logger();
            // constructor injection
            Employee employee1 = new Employee(logger);
            employee1.FirstName = "Dima";
            employee1.LastName = "Turki";
            employee1.PrintEmployeeInfo();


            // property injection
            Employee employee2 = new Employee();
            employee2.Logger = logger;
            employee2.FirstName = "Dima";
            employee2.LastName = "Turki";
            employee2.PrintEmployeeInfo();


            // method injection
            Employee employee3 = new Employee();
            employee3.SetDependency(logger);
            employee3.FirstName = "Dima";
            employee3.LastName = "Turki";
            employee3.PrintEmployeeInfo();

        }
    }
}
