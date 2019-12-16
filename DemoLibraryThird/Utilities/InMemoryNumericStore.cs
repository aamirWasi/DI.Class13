﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibraryThird.Utilities
{
    public class InMemoryNumericStore : INumericStore
    {
        public HashSet<int> _store = new HashSet<int>();

        public void Add(int number)
        {
            _store.Add(number);
        }

        public void Remove(int number)
        {
            _store.Remove(number);
        }

        public bool Contains(int number) => _store.Contains(number);
    }
}
