using DI.Class13.Third.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DI.Class13.Third.Repository.Concrete
{
    public class OptionService : IOptionService
    {
        private INumericStore _numericStore;
        private IPrinter _printer;

        public OptionService(INumericStore numericStore, IPrinter printer)
        {
            _numericStore = numericStore;
            _printer = printer;
        }

        public void DisableOption(int number)
        {
            _printer.Print($"Disable option is {number}");
            _numericStore.Remove(number);
            _printer.Print($"Option {number} is disabled");
        }

        public void EnableOption(int number)
        {
            _printer.Print($"Enable option is {number}");
            _numericStore.Add(number);
            _printer.Print($"Option {number} is enabled");
        }

        public bool IsOptionEnabled(int number) => _numericStore.Contains(number);
    }
}
