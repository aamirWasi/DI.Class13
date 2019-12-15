using DI.Class13.Second.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DI.Class13.Second.Repository.Concrete
{
    public class OptionService:IOptionService
    {
        private readonly INumericStore _numericStore;
        private readonly IPrinter _printer;

        public OptionService(INumericStore numericStore,IPrinter printer)
        {
            _numericStore = numericStore;
            _printer = printer;
        }

        public void EnableOption(int option)
        {
            _printer.Print($"Enable option is {option}...");
            _numericStore.Add(option);
            _printer.Print($"option {option} is enabled...");
        }

        public void DisableOption(int option)
        {
            _printer.Print($"disable option is {option}...");
            _numericStore.Add(option);
            _printer.Print($"option {option} is disabled...");
        }

        public bool IsOptionEnabled(int option) => _numericStore.Contains(option);
    }
}
