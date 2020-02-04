using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class MarketingFirm
    {
        ISweepStakesManager _manager;

        public MarketingFirm(ISweepStakesManager _manager)
        {
            this._manager = _manager;
        }

        public string SelectManagementType()
        {
            Console.WriteLine("How would you like to manage your sweepstakes?");
            Console.WriteLine("1- Stack");
            Console.WriteLine("2- Queue");
            string input = Console.ReadLine();
            return input;
        }
        public void CreateSweepstakes(string name)
        {
            SweepStakes sweepStakes = new SweepStakes(name);
            ManagerFactory managerFactory = new ManagerFactory();
            
            managerFactory.GetManager() = 
        }
    }
}
