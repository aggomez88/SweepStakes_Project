using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    static class UserInterface
    {
        public static string GetUserInputFor()
        {
            Console.WriteLine($"Hello please enter your login credentials");
            string admin = Console.ReadLine();
            return admin;
        }
        public static string ContestantFirstName()
        {
            Console.WriteLine("Please enter your first name...");
            string firstName = Console.ReadLine();
            return firstName;
        }
        public static string ContestantLastName()
        {
            Console.WriteLine("Please enter your last name...");
            string lastName = Console.ReadLine();
            return lastName;
        }
        public static string ContestantEmailAddress()
        {
            Console.WriteLine("Please enter your email address...");
            string emailAddress = Console.ReadLine();
            return emailAddress;
        }
        public static int RegistrationNumber()   //Dictonary key and Registration number are NOT the same.  Dictionary Key is being generated randomly as well.
        {                                           // Have registration number be the next available spot in the dictionary ---> count++
            Random random = new Random();

            int registrationNumber = random.Next(0, 1000);

            return registrationNumber;
        }
        public static Contestant AddContestant()
        {
            Contestant newContestant = new Contestant();

            newContestant.FirstName = ContestantFirstName();
            newContestant.LastName = ContestantLastName();
            newContestant.EmailAddress = ContestantEmailAddress();
            newContestant.RegistrationNumber = RegistrationNumber();

            return newContestant;
        }


    }
}
