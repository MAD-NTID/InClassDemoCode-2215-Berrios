using System;

namespace Week6Day3___DoWhile_And_While_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Number Counter - Ask the user for a start and a end number
            //  Iterate through the numbers until the test condition fails

            Console.Write("Please enter a number to start counting: ");
            int startNumber = int.Parse(Console.ReadLine());

            Console.Write("Please enter a number to stop counting: ");
            int stopNumber = int.Parse(Console.ReadLine());

            //  Two Variables to have the same start number on both loops
            int whileStartNumber = startNumber;
            int doWhileStartNumber = startNumber;

            #region While Loop
            //Console.WriteLine("While Loop");
            //while (whileStartNumber <= stopNumber)
            //{
            //    Console.WriteLine($"{whileStartNumber}");

            //    whileStartNumber++;
            //}

            //Console.WriteLine("-----------------");
            //Console.WriteLine("Do While");
            //do
            //{
            //    Console.WriteLine($"{doWhileStartNumber}");

            //    doWhileStartNumber++;
            //} while (doWhileStartNumber <= stopNumber);

            //Console.WriteLine("Finished Counting");
            #endregion

            #region The Never Ending Loop
            //while(true)
            //{
            //    Console.WriteLine($"{whileStartNumber}");
            //    whileStartNumber++;
            //}

            //do
            //{
            //    Console.WriteLine($"{doWhileStartNumber}");
            //    doWhileStartNumber++;
            //} while (true);
            #endregion
        }
    }
}
