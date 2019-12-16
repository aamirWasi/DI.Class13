using DI.Class13.FirstMVCProject.Sir.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Class13.FirstMVCProject.Sir.Services
{
    public class Welcome2Service : IWelcome2Service
    {
        private IWelcomeRepository _welcomeRepository;

        public Welcome2Service(IWelcomeRepository welcomeRepository)
        {
            _welcomeRepository = welcomeRepository;
        }

        public WelCome2Model WelcomeMessage()
        {
            var model = new WelCome2Model();
            var repo = _welcomeRepository.GetWelcomeRepository();
            model.Name = repo[0];
            model.Date = DateTime.Parse(repo[1]);
            model.Email = repo[2];

            return model;
        }
    }
}
