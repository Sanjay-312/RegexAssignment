using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexExplanation
{

    internal class PatternMatching
    {
        public static void validate_first_name()
        {
            Console.WriteLine("enter first name");
            string first_name = Console.ReadLine();

            string namepattern = "^[A-Z]{1}[a-zA-Z]{2,}$";
            Regex regobj = new Regex(namepattern);

            if (regobj.IsMatch(first_name))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("first name is valid");
                Console.ResetColor();

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("first name is not valid");
                Console.ResetColor();
            }
        }
        public static void validate_last_name()
        {
            Console.WriteLine("enter last name");
            string last_name = Console.ReadLine();

            string namepattern = "^[A-Z]{1}[a-zA-Z]{2,}$";
            Regex regobj = new Regex(namepattern);

            if (regobj.IsMatch(last_name))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("last name is valid");
                Console.ResetColor();

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("last name is not valid");
                Console.ResetColor();
            }
        }
        public static void validate_email()
        {
            Console.WriteLine("enter email");
            string email = Console.ReadLine();

            string namepattern = "^[a-z]{1,}([-.+]{1}){0,1}([0-9]{1,}){0,1}[@]{1}[a-z0-9]{1,}[.][a-zA-Z]{2,3}([.]{1}[a-z]{2,3}){0,1}$";
            Regex regobj = new Regex(namepattern);

            if (regobj.IsMatch(email))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("email is valid");
                Console.ResetColor();

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("email is not valid");
                Console.ResetColor();
            }
        }

        public static void validate_mobile_number()
        {
            Console.WriteLine("enter mobile number");
            string mobilenumber = Console.ReadLine();
            string namepattern = "^[1-9]{2}[ ]{1}[0-9]{10}$";
            Regex regobj = new Regex(namepattern);

            if (regobj.IsMatch(mobilenumber))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("mobile number is valid");
                Console.ResetColor();

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("mobile number is not valid");
                Console.ResetColor();
            }
        }









    }
}
