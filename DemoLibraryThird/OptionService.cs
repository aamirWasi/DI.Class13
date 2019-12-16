using DemoLibraryThird.Utilities;
using System;

namespace DemoLibraryThird
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

        public void DisableOption(int option)
        {
            _logger.Log($"Disable option is {option}");
            _numericStore.Remove(option);
            _logger.Log($"Option {option} is now disabled...");
        }

        public bool IsOptionEnabled(int option)
        {
            return _numericStore.Contains(option);
        }
    }
}
