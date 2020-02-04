using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class SweepStakesQueueManager : ISweepStakesManager
    {
        Queue<SweepStakes> queue = new Queue<SweepStakes>();

        public SweepStakes GetSweepStakes()
        {
            return queue.Dequeue();
        }

        public void InsertSweepstakes(SweepStakes sweepStakes)
        {
            queue.Enqueue(sweepStakes);
        }
    }

        
    
}
