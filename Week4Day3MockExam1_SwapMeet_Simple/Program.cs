using System;

namespace Week4Day3MockExam1_SwapMeet_Simple
{
    class Program
    {
        static void Main(string[] args)
        {
            const string BUSINESS_NAME = "Disk4Cheap";

            Console.WriteLine($"**{BUSINESS_NAME}**\n");

            const double PRICE = 25.75;

            Console.Write("How many disk drives are in the current inventory? ");
            if (int.TryParse(Console.ReadLine(), out int inventoryCount))
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Display current inventory value");
                Console.WriteLine($"2. Buy disk from {BUSINESS_NAME}");
                Console.WriteLine($"3. Sell disks to {BUSINESS_NAME}");
                Console.WriteLine("4. Exit");

                Console.Write("Selection: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Inventory count: {0} Value: {1:C}", inventoryCount, PRICE * inventoryCount);
                        break;
                    case "2":
                        Console.Write("How many disk do you want to purchase? ");
                        int purchase = int.Parse(Console.ReadLine());
                        inventoryCount -= purchase;
                        Console.WriteLine("Inventory count: {0}\tValue: {1:C}", inventoryCount, PRICE * inventoryCount);
                        break;
                    case "3":
                        Console.Write("How many disk do you want to sell? ");
                        int sell = int.Parse(Console.ReadLine());
                        inventoryCount += sell;
                        Console.WriteLine("Inventory count: {0}\tValue: {1:C}", inventoryCount, PRICE * inventoryCount);
                        break;
                    case "4":
                        Console.WriteLine("Thank you for visiting us");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("The value you entered is invalid...exiting");
                        break;
                }

                Console.WriteLine("Program end... exiting");
            }
            else
            {
                Console.WriteLine("Error: The value you enter is invalid...exiting");
            }
        }
    }
}
