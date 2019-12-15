using System;

namespace DI.Class13.First
{
    class Program
    {
        static void Main(string[] args)
        {
            var printer = new Printer();
            var numericStore = new InMemorynumericStore(printer);
            var optionService = new OptionsService(numericStore, printer);
            var application = new Application(optionService,printer);
            application.Run();
        }
    }
}
