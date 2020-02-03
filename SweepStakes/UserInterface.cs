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

        public static string GetUserInputFor(string admin)
        {
            Console.WriteLine($"Hello please enter your login credentials");
            admin = Console.ReadLine();
            return admin;
        }
        public static string ContestantFirstName()
        {
            Console.WriteLine("Please enter your first name...");
            string firstName = Console.ReadLine();
            return firstName;
        }
        public static string ContestantLastName(string lastName)
        {
            Console.WriteLine("Please enter your last name...");
            lastName = Console.ReadLine();
            return lastName;
        }
        public static string ContestantEmailAddress(string emailAddress)
        {
            Console.WriteLine("Please enter your email address...");
            emailAddress = Console.ReadLine();
            return emailAddress;
        }
        public static int RegistrationNumber(int registrationNumber)
        {
            registrationNumber = random.Next(0, 1000);
            return registrationNumber;
        }
        
    }
}
