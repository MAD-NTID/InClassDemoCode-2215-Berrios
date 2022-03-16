using System;

namespace Week9Day1___2D_Arrays
{
    class Program
    {
        const int RANDOM_LOW = 0, RANDOM_HIGH = 100;
        const int ROWS = 8;
        const int COLS = 4;

        static void Main(string[] args)
        {
            //  Make the 2D array
            int[,] nameOfTheTwoDArray = GenerateRandomIntegers(ROWS, COLS);

            ShowRandomNumbers(nameOfTheTwoDArray);

            //  Scenario - Everyone has a favorite number 25 and want to assign it to the first column
            //nameOfTheTwoDArray = ReplaceColumnNumber(nameOfTheTwoDArray, 0, 25);

            //  Scenario - Prompt the user to enter a column number to replace, and the integer number value, validate
            int col = 0, number = 0;

            while(true)
            {
                Console.Write($"Which column do you want to replace for everyone? 1 to {COLS}: ");

                if(int.TryParse(Console.ReadLine(), out col) && (col > 0 && col <= COLS))
                {
                    //  Convert to zero based index so that the program does not throw index out of bounds exception
                    col--;

                    while (true)
                    {
                        Console.Write($"What number would you like to replace the column with? ");

                        if(int.TryParse(Console.ReadLine(), out number))
                        {
                            nameOfTheTwoDArray = ReplaceColumnNumber(nameOfTheTwoDArray, col, number);

                            //  Break out of the second loop
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input, integers only");
                        }
                    }

                    //  Break out of the first loop
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Column");
                }
            }

            Console.WriteLine($"\n==== Assign {number} to everyone's Column #{col + 1} ====\n");

            ShowRandomNumbers(nameOfTheTwoDArray);
        }

        public static int[,] GenerateRandomIntegers(int rows, int cols)
        {
            int[,] nameOfTheTwoDArray = new int[rows, cols];

            Random random = new();

            //  First for loop is for looping the rows
            for (int i = 0; i < rows; i++)
            {
                //  Second for loop is for looping the columns of above row
                for (int y = 0; y < cols; y++)
                {
                    //  Assign a random int to each column for every row
                    nameOfTheTwoDArray[i, y] = random.Next(RANDOM_LOW, RANDOM_HIGH + 1);
                }
            }

            return nameOfTheTwoDArray;
        }

        public static void ShowRandomNumbers(int[,] twoDArray)
        {
            //  Print out the rows and columns
            //  First for loop is for looping the rows
            for (int i = 0; i < ROWS; i++)
            {
                Console.Write($"Row {i + 1}: ");

                //  Second for loop is for looping the columns of above row
                for (int y = 0; y < COLS; y++)
                {
                    Console.Write($"{twoDArray[i, y], -6}");
                }

                //  This extra CW adds a space to format the NEXT row
                //  This space is added after the columns loop is complete
                Console.WriteLine();
            }
        }

        public static int[,] ReplaceColumnNumber(int[,] twoDArray, int column, int value)
        {
            //nameOfTheTwoDArray[0, 0] = 25;
            //nameOfTheTwoDArray[1, 0] = 25;
            //nameOfTheTwoDArray[2, 0] = 25;
            //...
            //nameOfTheTwoDArray[7, 0] = 25;

            for (int i = 0; i < ROWS; i++)
            {
                twoDArray[i, column] = value;
            }

            return twoDArray;
        }
    }
}
