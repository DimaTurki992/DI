using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DIP.Controllers
{
    [Route("/api/employee")]
    [ApiController]
    public class EmployeeController : Controller
    {
        private readonly IDataAccessService _dataAccessService;
        public EmployeeController(IDataAccessService dataAccessService)
        {
            _dataAccessService = dataAccessService;
        }

        [HttpGet()]
        public void PrintEmployeeInfo()
        {
            // constructor injection
            Employee employee1 = _dataAccessService.Get(1);
            employee1.PrintEmployeeInfo();

            // method injection 
            Employee employee3 = _dataAccessService.Get(2);
            Logger logger = new Logger();
            employee3.SetDependency(logger);
            employee3.PrintEmployeeInfo();


        }
    }
}
