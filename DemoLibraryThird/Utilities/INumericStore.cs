namespace DemoLibraryThird.Utilities
{
    public interface INumericStore
    {
        void Add(int number);
        bool Contains(int number);
        void Remove(int number);
    }
}