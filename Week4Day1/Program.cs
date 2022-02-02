using System;

namespace Week4Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            //  GOAL: Use TryParse and Nested If Statements / Maybe Negation Logical Operator

            //  Create a Pizza program where users can select options for pizza toppings
            //  Each toppings cost .50 cents - up to two toppings
            //  Small pizza is 8 dollars
            //  Medium pizza is 10 dollars
            //  Large pizza is 12 dollars
            //  New York State Tax is 8%
            //  Calculate the total cost including tax

            const double NYS_TAX = .08;

            const double SMALL_PRICE = 8;
            const double MEDIUM_PRICE = 10;
            const double LARGE_PRICE = 12;

            const double TOPPING = .5;

            double subtotal = 0;
            double tax = 0;
            double total = 0;

            Console.WriteLine("Choose a Pizza Pie Size: \n1. Small\n2. Medium\n3. Large");

            if (int.TryParse(Console.ReadLine(), out int option))
            {
                if(option >= 1 && option <= 3)
                {
                    #region When option is valid
                    if (option == 1)
                    {
                        subtotal += SMALL_PRICE;
                    }
                    else if (option == 2)
                    {
                        subtotal += MEDIUM_PRICE;
                    }
                    else
                    {
                        subtotal += LARGE_PRICE;
                    }

                    Console.WriteLine("Add Toppings Pepperoni (yes/no): ");
                    string pepperoni = Console.ReadLine();
                    if (pepperoni == "yes" || pepperoni == "Yes")
                    {
                        subtotal += TOPPING;
                    }
                    else if (pepperoni == "no" || pepperoni == "No")
                    {
                        // do nothing
                    }
                    else
                    {
                        Console.WriteLine("Invalid Choice");
                    }

                    Console.WriteLine("Add Toppings Veggies (yes/no): ");
                    string veggies = Console.ReadLine();

                    if (veggies.ToLower() == "yes")
                    {
                        subtotal += TOPPING;
                    }
                    else if (veggies.ToLower() == "no")
                    {
                        // do nothing
                    }
                    else
                    {
                        Console.WriteLine("Invalid Choice");
                    }

                    tax = subtotal * NYS_TAX;
                    total = subtotal + tax;

                    Console.WriteLine();
                    Console.WriteLine($"Subtotal: {subtotal:C}");
                    Console.WriteLine($"Tax: {tax:C}");
                    Console.WriteLine($"Total: {total:C}");
                    #endregion
                }
                else
                {
                    Console.WriteLine("Invalid Option. Only options 1 - 3");
                    // Program should end at this point
                    // The cheap way - It is valid way, but I want you to THINK. Let the program run its own course
                    //Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Try again.");
            }
        }
    }
}
