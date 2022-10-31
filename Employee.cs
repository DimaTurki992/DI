
namespace DIP
{
    public class Employee
    {
        private ILogger _logger;

        // property/setter injection

        public ILogger Logger
        {
            set { this._logger = value; }
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Employee() { }

        // constructor injction

        public Employee(ILogger logger)
        {
            _logger = logger;
        }


        // method injection
        public void SetDependency(ILogger logger)
        {
            _logger = logger;
        }

        public void PrintEmployeeInfo()
        {
            _logger.Log($"Employee's Name: {FirstName} {LastName}.");
        }

    }
}
