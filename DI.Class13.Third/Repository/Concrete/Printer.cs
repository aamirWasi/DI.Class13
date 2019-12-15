using DI.Class13.Third.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DI.Class13.Third.Repository.Concrete
{
    public class Printer : IPrinter
    {
        public void Print(string message)
        {
            Console.WriteLine($"{message}");
        }
    }
}
