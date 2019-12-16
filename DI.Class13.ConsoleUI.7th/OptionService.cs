using DemoLibrarySeventh.Utilities;
using System;

namespace DI.Class13.ConsoleUI._7th
{
    public class OptionService : IOptionService
    {
        private ILogger _logger;
        private INumericStore _numericStore;

        public OptionService(ILogger logger, INumericStore numericStore)
        {
            _logger = logger;
            _numericStore = numericStore;
        }

        public void EnableOption(int option)
        {
            _logger.Log($"Enable option is {option}");
            _numericStore.Add(option);
            _logger.Log($"Option {option} is now enabled...");
        }
    }
}
