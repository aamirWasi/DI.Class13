using DI.Class13.FirstMVCProject.Sir.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Class13.FirstMVCProject.Sir.Services
{
    public class WelcomeService : IWelcomeService
    {
        private IWelcomeRepository _welcomeRepository;

        public WelcomeService(IWelcomeRepository welcomeRepository)
        {
            _welcomeRepository = welcomeRepository;
        }

        public WelComeModel WelcomeMessage()
        {
            var model = new WelComeModel();
            var repo = _welcomeRepository.GetWelcomeRepository();
            model.Name = repo[0];
            model.Date = DateTime.Parse(repo[1]);

            return model;
        }
    }
}
