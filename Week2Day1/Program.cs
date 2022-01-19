using System;

namespace Week2Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region String Simple Formatting
            //int age = 50;
            //double height = 6.1;
            //double weight = 120;

            //Console.WriteLine("My age is " + age + " and my height is " + height + " and my weight is " + weight);

            //Console.WriteLine();

            //Console.WriteLine("My age is {0} and my height is {1} and my weight is {2}", age, height, weight);

            //Console.WriteLine();

            //Console.WriteLine($"My age is {age} and my height is {height} and my weight is {weight}");
            #endregion

            #region Changing a Value using Assignment Operator
            //string variableA = "Some value here";

            //Console.WriteLine(variableA);

            //variableA = "Wait, I wanna change the value";

            //Console.WriteLine(variableA);
            #endregion

            #region Space does MATTER
            //int



            //    variable



            //    =

            //    0;

            //Console.WriteLine(variable);
            #endregion

            #region Statements and Expressions
            ////  this is a statement, simply declare a variable and assign a value
            //int valueA = 5;

            ////  same here...

            //int valueB = 10;
            ////  this is an expression, it does a "calculation" and returns a value
            //int results = valueA + valueB;

            //Console.WriteLine(results);
            #endregion

            #region Multiple Declaration with same Type
            //string variableA, variableB, variableC;
            #endregion

            #region Multiple Declaration with Same Type and Assign values simultaneously
            //string variableD = "D", variableE = "E", variableF = "F";
            #endregion

            #region Precision Loss vs Keep
            //int valueA = 6;
            //int valueB = 5;
            ////  here, you lose precision
            //Console.WriteLine(valueA / valueB);

            //double valueC = 6;
            //double valueD = 5;
            ////  here, you keep precision (decimals)
            //Console.WriteLine(valueC / valueD);
            #endregion

            #region Prefix and Postfix
            //int x = 5;

            ////  Prefix
            ////int y = ++x;

            ////Console.WriteLine(y);  // This is 6

            ////  Postfix
            //int y = x++;

            //Console.WriteLine(y);   // This is 5
            //Console.WriteLine(x);   // This is 6
            #endregion

            #region Comparative Operators and Boolean Results
            //Console.WriteLine(5 > 6);   // False

            //bool resultA = 5 > 6;

            //Console.WriteLine("5 > 6 " + resultA);  // False

            //bool resultB = 5 >= 5;

            //Console.WriteLine("5 >= 5 " + resultB); // True

            //bool resultC = 10 == 11;

            //Console.WriteLine("10 == 11 " + resultC); // False
            #endregion

            #region Implicit and Explicit Type Conversion
            //double x = 5, y = 21;
            //double result = y / x;

            //Console.WriteLine(result);  // 4.2

            ////  Explicit Conversion
            //int resultExplicit = (int)(y / x);
            //Console.WriteLine(resultExplicit);   // 4

            ////  Implicit Conversion
            //int a = 5, b = 21;
            //double resultImplicit = b / a;

            //Console.WriteLine(resultImplicit);  // 4
            #endregion


        }
    }
}
