using System;

namespace DI.Class13.First
{
    public class Printer : IPrinter
    {
        public void Print(string message)
        {
            Console.WriteLine($"{message}");
        }
    }
}
