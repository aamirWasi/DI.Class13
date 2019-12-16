using System;
using System.Collections.Generic;
using System.Text;

namespace DI.Class13._4th.DemoLibrary.Utilities
{
    public class DataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("Loading Data...");
        }

        public void SaveData(string name)
        {
            Console.WriteLine($"Saving {name}");
        }
    }
}
