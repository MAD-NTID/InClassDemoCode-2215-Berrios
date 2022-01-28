using System;

namespace Week3Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Complex Boolean expressions
            //bool answerC = (true || (false && true)) || false && true;

            //Console.WriteLine(answerC);
            #endregion

            #region Sales Commision 7% else if 10% too
            //const double COMMISSION_RATE_7_PERCENT = .07;
            //const double COMMISSION_RATE_10_PERCENT = .1;

            //Console.Write("How much is the sale of the car? ");

            //double sales = double.Parse(Console.ReadLine());
            //double commission = 0;

            ////  the requirement is that must sell the car for 10,000 or more
            //if (sales >= 10000)
            //{
            //    //  we need to determine which commission rate Justin gets

            //    //  if Justin sells the car for 100,000 or more
            //    if(sales >= 100000)
            //    {
            //        commission = sales * COMMISSION_RATE_10_PERCENT;
            //    }
            //    //  otherwise, just 7%
            //    else
            //    {
            //        commission = sales * COMMISSION_RATE_7_PERCENT;
            //    }
            //}

            //Console.WriteLine($"Justin earned {commission:C}");
            #endregion

            #region Scoping
            //// The Problem...
            ////string firstName = "michael";

            ////if (firstName == "michael")
            ////{
            ////    //  lastname is inside a scope, program can't see it
            ////    firstName = "I can see firstName";
            ////    string lastName = "berrios";
            ////}

            ////  The Solution - declare lastName outside of the if statement to solve scoping problem
            ////Console.WriteLine(firstName + " " + lastname);
            //string firstName = "michael";
            //string lastName = "";

            //if (firstName == "michael")
            //{
            //    //  lastname is inside a scope, program can't see it
            //    firstName = "I can see firstName";
            //    lastName = "berrios";
            //}

            //Console.WriteLine(firstName + " " + lastName);
            #endregion
        }
    }
}
