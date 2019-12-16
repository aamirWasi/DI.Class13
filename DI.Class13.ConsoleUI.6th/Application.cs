using DemoLibraryThird;
using DemoLibraryThird.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DI.Class13.ConsoleUI._6th
{
    public class Application : IApplication
    {
        private IOptionService _optionService;

        public Application(IOptionService optionService)
        {
            _optionService = optionService;
            //Initialize();
        }

        private void Initialize()
        {
        }

        public void Run()
        {
            _optionService.EnableOption(1);
            _optionService.DisableOption(2);
        }
    }
}
