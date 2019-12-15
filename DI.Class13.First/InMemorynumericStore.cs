using System.Collections.Generic;

namespace DI.Class13.First
{
    public class InMemorynumericStore : INumericStore
    {
        private IPrinter _printer;
        private readonly HashSet<int> _stored = new HashSet<int>();

        public InMemorynumericStore(IPrinter printer)
        {
            _printer = printer;
        }

        public void Add(int number) => _stored.Add(number);
        public void Remove(int number) => _stored.Remove(number);
        public bool Contains(int number) => _stored.Contains(number);
    }
}
