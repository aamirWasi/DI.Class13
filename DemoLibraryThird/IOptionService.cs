namespace DemoLibraryThird
{
    public interface IOptionService
    {
        void DisableOption(int option);
        void EnableOption(int option);
        bool IsOptionEnabled(int option);
    }
}