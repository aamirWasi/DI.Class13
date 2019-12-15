using DI.Class13.Second.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DI.Class13.Second.Repository.Concrete
{
    public class InMemoryNumericStore:INumericStore
    {
        private readonly HashSet<int> _store = new HashSet<int>();
        public void Add(int number) => _store.Add(number);
        public void Remove(int number) => _store.Remove(number);
        public bool Contains(int number) => _store.Contains(number);
    }
}
