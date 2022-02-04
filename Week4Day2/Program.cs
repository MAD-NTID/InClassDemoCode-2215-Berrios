using System;

namespace Week4Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to dress up warm? (y/n): ");

            switch(Console.ReadLine().ToLower())
            {
                case "y":
                case "yh":
                case "yeah":
                case "yup":
                case "yes":
                    Console.WriteLine("Alright, go ahead, it's snowing outside");
                    break;
                case "n":
                case "no":
                case "nope":
                case "nay":
                case "nah":
                    Console.WriteLine("Boy/Girl, you must be nuts, it's cold outside");
                    break;
                default:
                    Console.WriteLine("Invalid Input. Answer (y/n).");
                    break;
            }
        }
    }
}
