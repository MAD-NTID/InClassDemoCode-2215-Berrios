using System;

namespace Week11Day1
{
    class Program
    {
        enum Months
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }

        static void Main(string[] args)
        {
            #region Search the Enum for a Match
            Console.Write("Enter a named month to show the month number: ");
            string input = Console.ReadLine();

            //  This line will fail if the user doesn't provide an input or provides a valid month
            //Months month = (Months) Enum.Parse(typeof(Months), input, true);
            //  Instead, use Enum.TryParse

            if(Enum.TryParse(typeof(Months), input, true, out object month))
            {
                Console.WriteLine($"You chose month {month} and the month number is {(int)month}");
            }
            else
            {
                Console.WriteLine($"Invalid month {input}");
            }
            #endregion

            Console.Write("Enter number of the month to show the name of the month: ");

            if(int.TryParse(Console.ReadLine(), out int monthNumber) && monthNumber >= Enum.GetValues(typeof(Months)))
            {

            }
            else
            {
                Console.WriteLine("Invalid input");
            }

            #region Iterating an Enum
            //  In order to iterate an Enum we must first convert it to an array

            foreach (int i in Enum.GetValues(typeof(Months)))
            {
                Console.WriteLine($"Month: {(Months)i}");
            }
            #endregion


            Console.WriteLine($"The lenght of the Months enum is {Enum.GetValues(typeof(Months)).Length}");
        }
    }
}
