using System;

namespace Week7Day1___Some_Math_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Collect two random integer value
            int value1 = GetRandomInteger(), 
                value2 = GetRandomInteger();

            Console.WriteLine($"The two random values are Value 1: {value1} and Value 2: {value2}\n");

            Console.WriteLine($"The sum is {CalculateSum(value1, value2)}");

            Console.WriteLine($"The product is {Product(value1, value2)}");

            Console.WriteLine($"The division is {Divide(value1, value2)}");

            Console.WriteLine($"The highest value is {GetTheMaxNumber(value1, value2)}");
        }

        public static int GetRandomInteger()
        {
            Random ran = new Random();

            //  Gets a random value 1 - 50
            int randomInteger = ran.Next(1, 51);

            return randomInteger;
        }

        public static int CalculateSum(int value1, int value2)
        {
            return (value1 + value2);
        }

        public static int Product(int value1, int value2)
        {
            return (value1 * value2);
        }

        public static double Divide(int value1, int value2)
        {
            return (double) value1 / value2;
        }

        public static int GetTheMaxNumber(int value1, int value2)
        {
            return Math.Max(value1, value2);
        }
    }
}
