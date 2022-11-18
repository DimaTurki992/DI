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

        [HttpGet("{id}")]
        public void PrintEmployeeInfo(int id)
        {
            Employee employee1 = _dataAccessService.GetEmployeeById(id);
            employee1.PrintEmployeeInfo();
        }
    }
}
