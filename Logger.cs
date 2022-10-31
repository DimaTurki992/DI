using System;

namespace DIP
{
    public class Logger: ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
