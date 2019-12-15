using DI.Class13.Second.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DI.Class13.Second
{
    public class Application
    {
        private IOptionService _optionService;
        private IPrinter _printer;

        public Application(IOptionService optionService,IPrinter printer)
        {
            _optionService = optionService;
            _printer = printer;
            Initialize();
        }

        private void Initialize()
        {
            _optionService.EnableOption(1);
            _optionService.DisableOption(2);
        }
        public void Run()
        {
            if (_optionService.IsOptionEnabled(1))
                _printer.Print("Do something ...");
        }
    }
}
