using System;

namespace Week2Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Explicit Conversion 
            //int firstScore = 85;
            //int secondScore = 68;

            //int intResult = (firstScore + secondScore) / 2;
            ////  Need at least one of the datatypes to be a precision value
            //float floatResult = (firstScore + secondScore) / (float) 2;
            //double doubleResult = (firstScore + secondScore) / (double) 2;

            //Console.WriteLine("Integer Result: " + intResult);
            //Console.WriteLine("Float Result: " + floatResult);
            //Console.WriteLine("Double Result: " + doubleResult);
            #endregion

            #region Changing a Constant Variable
            //const double NEVER_CHANGE = 50.5;

            //Console.WriteLine(NEVER_CHANGE);

            ////  Illegal to change Constant value
            //NEVER_CHANGE = 60;
            #endregion

            #region Constant as NY Tax
            ////  Declared a Constant Variable for NYS Sales Tax
            //const double NYS_SALES_TAX  = .08; // 8%

            //double pairOfNikes = 80;

            ////  We used the Constant variable to perform an mathmatical expression
            //double tax = (NYS_SALES_TAX * pairOfNikes);

            //double total = pairOfNikes + tax;

            ////  We display using formatting to show currency
            //Console.WriteLine($"Pair of Nikes: {pairOfNikes:C}\nTax: {tax:C}\nTotal: {total:C}");
            #endregion

            #region Reading Input from the User
            //Console.Write("Please enter the score for exam #1: ");
            //float exam1 = float.Parse(Console.ReadLine());

            //Console.Write("Please enter the score for exam #2: ");
            //float exam2 = float.Parse(Console.ReadLine());

            //Console.Write("Please enter the score for exam #3: ");
            //float exam3 = float.Parse(Console.ReadLine());

            //float result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine($"The average for all 3 exams is: {result}");
            #endregion
        }
    }
}
