using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class ManagerFactory
    {
        public ISweepStakesManager GetManager(string type)
        {
            ISweepStakesManager user = null;
            switch (type)
            {
                case "Stack":
                    user = new SweepStakesStackManager();
                    break;
                case "Queue":
                    user = new SweepStakesQueueManager();
                    break;
                default:
                    Console.WriteLine("Not a valid role");
                    GetManager(type);
                    break;
            }
            return user;
        } 
    }
}
