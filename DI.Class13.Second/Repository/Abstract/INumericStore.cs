using System;
using System.Collections.Generic;
using System.Text;

namespace DI.Class13.Second.Repository.Abstract
{
    public interface INumericStore
    {
        void Add(int number);
        void Remove(int number);
        bool Contains(int number);
    }
}
