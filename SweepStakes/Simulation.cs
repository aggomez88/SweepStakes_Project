using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Simulation
    {
        public void CreateMarketingFirmWithManager()
        {
            string _manager;
            ManagerFactory managerFactory = new ManagerFactory();
            ISweepStakesManager manager = managerFactory.GetManager("Queue");
            int age = 32;
            MarketingFirm marketingFirm = new MarketingFirm(manager);
            
        }
    }
}
