using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Program
    {
        static void Main(string[] args)
        {
            // RESEARCH FACTORY PATTERNS ***(dot net perals)***
            // REVIEW STACK SLIDES (PUSH, POP) --> .PUSH/ .POP
            // REVIEW QUEUE SLIDES (ENQUEUE, DEQUEUE)--> .ENQUEUE/ .DEQUEUE 
            // 
            //Contestant contestant = new Contestant();
            //contestant.FirstName = UserInterface.ContestantFirstName();

            SweepStakes sweepstakes = new SweepStakes("Used Cars");

            Contestant cont = UserInterface.AddContestant();

            sweepstakes.RegisterContestant(cont);
            sweepstakes.PrintContestantInfo(cont);
        }
    }
}
