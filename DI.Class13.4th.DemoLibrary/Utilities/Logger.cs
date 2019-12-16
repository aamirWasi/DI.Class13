using System;
using System.Collections.Generic;
using System.Text;

namespace DI.Class13._4th.DemoLibrary.Utilities
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Logging : {message}");
        }
    }
}
