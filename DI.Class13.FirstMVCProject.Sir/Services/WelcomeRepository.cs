using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI.Class13.FirstMVCProject.Sir.Services
{
    public class WelcomeRepository : IWelcomeRepository
    {
        public IList<string> GetWelcomeRepository()
        {
            var list = new List<string>
            {
                "aamir khan",
                "3/3/2019",
                "wasi3aamir@gmail.com"
            };

            return list;
        }
    }
}
