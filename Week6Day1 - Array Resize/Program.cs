using System;

namespace Week6Day1___Array_Resize
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is how you resize an array without losing any data
            //const int INITIAL_SIZE = 5;

            //int[] numbers = new int[INITIAL_SIZE];

            //const int NEW_SIZE = 10;

            //int[] numbersNew = new int[numbers.Length + NEW_SIZE];

            ////  copy the smaller array to the bigger array
            //numbers.CopyTo(numbersNew, 0);

            ////  overwrite the old array with the new size
            //numbers = new int[numbers.Length + NEW_SIZE];

            ////  copy the bigger array back to the original array
            //numbersNew.CopyTo(numbers, 0);

            //  This is how you resize an array but you will lose any data
            const int INITIAL_SIZE = 5;

            int[] numbers = new int[INITIAL_SIZE];

            const int NEW_SIZE = 10;

            numbers = new int[numbers.Length + NEW_SIZE];
        }
    }
}
