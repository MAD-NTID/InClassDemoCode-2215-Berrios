using System;

namespace Week6Day3___Validating_Input_with_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            #region The One Question Jeopardy Game
            //const int ANSWER = 1965;

            //int year;

            //do
            //{
            //    Console.Write($"When was NTID established? ");
            //    if(int.TryParse(Console.ReadLine(), out year))
            //    {
            //        if (year == ANSWER)
            //        {
            //            Console.WriteLine("Yay, you win!");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Loser, Try Again!");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Error, please put a number only");
            //    }
            //} while (year != ANSWER);
            #endregion

            #region Username and Password Validations
            const string USERNAME = "NMAD180";
            const string PASSWORD = "EAVAFKM";

            while (true)
            {
                Console.Write("Please enter your username: ");
                string username = Console.ReadLine();

                Console.Write("Please enter your password: ");
                string password = Console.ReadLine();

                if (username == USERNAME && password == PASSWORD)
                {
                    Console.WriteLine("Login Correct!");

                    break;
                }
                else
                {
                    Console.WriteLine("Login Incorrect!\n");
                }
            }

            // THE Student Version
            //Console.Write("Please enter your username: ");
            //string username = Console.ReadLine();

            //Console.Write("Please enter your password: ");
            //string password = Console.ReadLine();

            //if(username == USERNAME && password == PASSWORD)
            //{
            //    do
            //    {
            //        Console.WriteLine("Login Correct!");

            //        break;
            //    } while (username == USERNAME && password == PASSWORD);
            //}

            //else
            //{
            //    do
            //    {
            //        Console.WriteLine("Login Incorrect!");

            //        break;
            //    } while (username != USERNAME && password != PASSWORD);
            //}
            #endregion
        }
    }
}
