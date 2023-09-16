using System.Text.RegularExpressions;

namespace RegexExplanation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("select option for validating : \n" +
                    "1.to check first name \n" +
                    "2.to check last name\n");

            Console.WriteLine("enter the option");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    PatternMatching.validate_first_name();
                    break;
                case 2:
                    PatternMatching.validate_last_name();
                    break;
                case 3:
                    PatternMatching.validate_email();
                    break;
                default:
                    Console.WriteLine("enter valid input");
                    break;

            }
        }
    }
}