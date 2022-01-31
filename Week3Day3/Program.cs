using System;

namespace Week3Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Random Number Dice Game
            //const int DIE_MIN_VALUE = 1;
            //const int DIE_MAX_VALUE = 7; // when use in randomizer we get 1-7
            //const int WINNING_VALUE = 15;

            //Random randomizer = new();

            //int die1 = randomizer.Next(DIE_MIN_VALUE, DIE_MAX_VALUE);
            //int die2 = randomizer.Next(DIE_MIN_VALUE, DIE_MAX_VALUE);
            //int die3 = randomizer.Next(DIE_MIN_VALUE, DIE_MAX_VALUE);

            //int totalValueFromDice = die1 + die2 + die3;

            //Console.WriteLine("Die Values: {0} - {1} - {2}", die1, die2, die3);

            //int extraValue = 0;

            //if (die1 == die2 && die1 == die3 && die2 == die3)
            //{
            //    extraValue = 6;
            //}
            //else if (die1 == die2 || die1 == die3 || die2 == die3)
            //{
            //    extraValue = 2;

            //}

            //Console.WriteLine($"Points Earned: {extraValue}");
            //Console.WriteLine($"Die Values: {totalValueFromDice}");

            //extraValue = totalValueFromDice + extraValue;

            //if (extraValue >= WINNING_VALUE)
            //{
            //    Console.WriteLine("You win the game!");
            //}
            //else
            //{
            //    Console.WriteLine("You lost the game");
            //}

            //Console.WriteLine($"Die Values: {extraValue}");
            //Console.ReadLine();
            #endregion

            #region TryParse
            ////  Getting age using TryParse
            //Console.Write("Type in your age: ");

            //int age = 0;

            //if (int.TryParse(Console.ReadLine(), out age))
            //{
            //    Console.WriteLine("Your age is {0}", age);
            //}
            //else
            //{
            //    Console.WriteLine("You input an invalid age");
            //}
            #endregion

            #region TryParse two different values at the same time
            ////  Try Parse two values
            //int userID = 0;
            //int password = 0;

            //Console.Write("Enter your user ID: ");
            //string userIDString = Console.ReadLine();

            //Console.Write("Enter your password: ");
            //string passwordString = Console.ReadLine();

            //if (int.TryParse(userIDString, out userID) && int.TryParse(passwordString, out password))
            //{
            //    Console.WriteLine("Successfully logged in");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid values provided");
            //}
            #endregion

            #region Explained - Broken Down
            //int.Parse("5"); // this will parse okay, it's a number
            //int.Parse("world"); // this will not parse okay, will crash (key word "CRASH")

            ////  TRY PARSE returns two values, a "boolean" and the "number value"
            ////  YOU USE the boolean value for the "if" statement
            //int.TryParse("5", out int number); // this will parse, it's a numbver
            //int.TryParse("world", out int anotherNumber);  // this will fail to parse, but NOT CRASH

            //bool passedOrFail = int.TryParse("10", out int value);

            //Console.WriteLine($"The parsing failed? {passedOrFail} and the value is {value}");
            #endregion
        }
    }
}
