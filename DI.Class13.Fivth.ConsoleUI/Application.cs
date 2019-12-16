using DI.Class13.Fivth.DemoLibrarySecond;
using System;
using System.Collections.Generic;
using System.Text;

namespace DI.Class13.Fivth.ConsoleUI
{
    public class Application : IApplication
    {
        private readonly IBusinessLogic _businessLogic;

        public Application(IBusinessLogic businessLogic)
        {
            _businessLogic = businessLogic;
        }

        public void Run()
        {
            _businessLogic.ProcessData();
        }
    }
}
