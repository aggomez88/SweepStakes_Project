using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class SweepStakes
    {

        //Member Variables (HAS A)
        public Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();

        string name;
        public string Name;
        int counter = 0;

        //Constructor
        public SweepStakes(string name)
        {
            this.name = name;
        }
        //Member Methods (CAN DO)
        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(counter, contestant); //Is executing method twice--> in creating new Cont. and Adding to Dictionary **CHANGE**
            counter++;
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(contestant.FirstName);
            Console.WriteLine(contestant.LastName);
            Console.WriteLine(contestant.EmailAddress);
            Console.WriteLine(contestant.RegistrationNumber);
        }
        public Contestant PickWinner()
        {
            Random random = new Random();
            int winningNumber = random.Next(0, counter);
            Contestant contestant = contestants[winningNumber];

            return contestant;
        }
        



    }
}
