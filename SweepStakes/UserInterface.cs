using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    static class UserInterface
    {
        public static Random random = new Random();

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
        public static int RegistrationNumber()
        {
            int registrationNumber = random.Next(0, 1000);
            return registrationNumber;
        }
        
    }
}
