using System;

namespace Week9Day2___Default_Empty_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Cheese cheese = new Cheese();

            while(true)
            {
                Console.Write($"Enter the cheese that you want {Cheese.AMERICAN}, {Cheese.PROVOLONE}, {Cheese.SWISS}: ");

                string cheeseToAdd = Console.ReadLine();

                if (cheese.HasCheese(cheeseToAdd))
                {
                    //  if the cheese entered exists, then add it
                    cheese.AddCheese(cheeseToAdd);

                    Console.WriteLine("Cheese as been added");
                }
                else
                {
                    Console.WriteLine("Sorry, invalid cheese");
                }

                Console.Write("Add More Cheese: ");
                if (Console.ReadLine().ToLower() != "y")
                    break;
            }

            //  Show all the cheese
            for(int i = 0; i < cheese.GetCheese().Length; i++)
            {
                if(!string.IsNullOrEmpty(cheese.GetCheese()[i]))
                    Console.WriteLine($"{i+1}: {cheese.GetCheese()[i]}");
            }
        }
    }
}
