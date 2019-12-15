using DI.Class13.Second.Repository.Concrete;
using System;

namespace DI.Class13.Second
{
    class Program
    {
        static void Main(string[] args)
        {
            var printer = new Printer();
            var numericStore = new InMemoryNumericStore();
            var optionService = new OptionService(numericStore, printer);
            var application = new Application(optionService, printer);
            application.Run();
        }
    }
}
