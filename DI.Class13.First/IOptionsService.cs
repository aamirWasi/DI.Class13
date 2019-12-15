namespace DI.Class13.First
{
    public interface IOptionsService
    {
        void DisableOption(int option);
        void EnableOption(int option);
        bool IsOptionEnabled(int option);
    }
}