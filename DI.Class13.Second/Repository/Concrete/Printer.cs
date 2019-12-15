using DI.Class13.Second.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DI.Class13.Second.Repository.Concrete
{
    public class Printer:IPrinter
    {
        public void Print(string message)
        {
            Console.WriteLine($"{message}");
        }
    }
}
