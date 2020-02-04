using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class SweepStakesStackManager : ISweepStakesManager
    {
        Stack<SweepStakes> stack = new Stack<SweepStakes>();

        public SweepStakes GetSweepStakes()
        {
            return stack.Pop();
        }

        public void InsertSweepstakes(SweepStakes sweepStakes)
        {
            stack.Push(sweepStakes);
        }
    }
}
