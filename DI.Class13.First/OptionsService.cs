namespace DI.Class13.First
{
    public class OptionsService : IOptionsService
    {
        private INumericStore _store;
        private IPrinter _printer;

        public OptionsService(INumericStore store, IPrinter printer)
        {
            _store = store;
            _printer = printer;
        }

        public void EnableOption(int option)
        {
            _printer.Print($"Enable option {option}...");
            _store.Add(option);
            _printer.Print($"option {option} is enabled...");
        }

        public void DisableOption(int option)
        {
            _printer.Print($"Disable option {option}...");
            _store.Remove(option);
            _printer.Print($"option {option} is disabled...");
        }

        public bool IsOptionEnabled(int option) => _store.Contains(option);
    }
}
