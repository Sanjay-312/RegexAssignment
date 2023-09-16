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
            string first_name=Console.ReadLine();

            string namepattern = "^[A-Z]{1}[a-zA-Z]{2,}$";
            Regex regobj=new Regex(namepattern);

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
        
        

        
       
    }
}
