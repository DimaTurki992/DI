
namespace DIP
{
    public class Employee
    {
        private readonly ILogger _logger;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Employee() { }

        public Employee(ILogger logger)
        {
            _logger = logger;
        }

        public void PrintEmployeeInfo()
        {
            _logger.Log($"Employee's Name: {FirstName} {LastName}.");
        }

    }
}
