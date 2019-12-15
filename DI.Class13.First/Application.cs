namespace DI.Class13.First
{
    public class Application
    {
        private IOptionsService _optionService;
        private IPrinter _printer;

        public Application(IOptionsService optionsService,IPrinter printer)
        {
            _optionService = optionsService;
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
            {
                _printer.Print("Do something...");
            }
        }
    }
}
