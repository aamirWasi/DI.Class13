using System;
using System.Collections.Generic;
using System.Text;

namespace DI.Class13.Third.Repository.Abstract
{
    public interface IOptionService
    {
        void EnableOption(int number);
        void DisableOption(int number);
        bool IsOptionEnabled(int number);
    }
}
