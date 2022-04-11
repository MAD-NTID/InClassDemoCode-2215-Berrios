using System;

namespace Week11Day3_Utilities
{
    class Program
    {
        static void Main(string[] args)
        {
            //string variable = "Something is here";

            //  traditional old way of doing it.
            //if(variable.IsNullOrEmpty())
            //{
            //    Console.WriteLine("Yea, it's null or empty");
            //}
            //else
            //{
            //    Console.WriteLine("No, it has something");
            //}

            //Console.Write("Do you want chocolate ice cream? (y/n): ");
            //string response = Console.ReadLine().YessesNays();

            //if(response == "y")
            //{
            //    Console.WriteLine("Okay, I'll buy you ice cream");
            //}
            //else if(response == "n")
            //{
            //    Console.WriteLine("Fine, your loss.");
            //}
            //else
            //{
            //    Console.WriteLine("Sorry, unknown response");
            //}

            Console.Write("Enter a word in lowercase to auto upper the first letter: ");
            string word = Console.ReadLine().ToUpperFirst();

            Console.WriteLine($"The new word is {word}");
        }
    }
}
