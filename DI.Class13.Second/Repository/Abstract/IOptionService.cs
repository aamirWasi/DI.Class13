using System;
using System.Collections.Generic;
using System.Text;

namespace DI.Class13.Second.Repository.Abstract
{
    public interface IOptionService
    {
        void EnableOption(int option);
        void DisableOption(int option);
        bool IsOptionEnabled(int option);
    }
}
