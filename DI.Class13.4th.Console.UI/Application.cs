using DI.Class13._4th.DemoLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace DI.Class13._4th.Console.UI
{
    public class Application : IApplication
    {
        private IBusinessLogic _businesslogic;

        public Application(IBusinessLogic businessLogic)
        {
            _businesslogic = businessLogic;
        }

        public void Run()
        {
            _businesslogic.ProcessData();
        }
    }
}
