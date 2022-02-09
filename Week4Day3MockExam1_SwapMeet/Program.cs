using System;

namespace Week4Day3MockExam1_SwapMeet
{
    class Program
    {
        static void Main(string[] args)
        {
            const string BUSINESS_NAME = "Disks4Cheap";
            const double DISK_COST = 25.75;

            const int MINIMUM_INVENTORY_ALLOWED = 0;
            const int MINIMUM_NUMBER_OF_DISKS_TO_SELL_ALLOWED = 0;

            Console.WriteLine($"***{BUSINESS_NAME}***\n");

            Console.Write("How many disk drivers are in the current inventory? ");
            if(int.TryParse(Console.ReadLine(), out int inventoryCount) && inventoryCount >= MINIMUM_INVENTORY_ALLOWED)
            {
                Console.WriteLine("MENU");
                Console.Write("1. Display current inventory value" +
                    $"\n2. Buy disks from {BUSINESS_NAME}" +
                    $"\n3. Sell disks to {BUSINESS_NAME}" +
                    $"\n4. Exit" +
                    $"\n\nEnter your choice here (1, 2, 3 or 4): ");

                if(int.TryParse(Console.ReadLine(), out int option) && option >= 1 && option <= 4)
                {
                    double inventoryValue;

                    switch (option)
                    {
                        case 1:
                            //  calculate the total inventory value
                            inventoryValue = inventoryCount * DISK_COST;

                            Console.WriteLine("Inventory Count: {0}\tValue: {1:C}", inventoryCount, inventoryValue);
                            break;
                        case 2:
                            Console.Write("How many disks do you want to purchase? ");
                            if(int.TryParse(Console.ReadLine(), out int numberOfDisksToBuy) && numberOfDisksToBuy > 0 && numberOfDisksToBuy <= inventoryCount)
                            {
                                //  substract the number of disks to buy
                                inventoryCount -= numberOfDisksToBuy;

                                //  calculate the total inventory value
                                inventoryValue = inventoryCount * DISK_COST;

                                Console.WriteLine("Inventory Count: {0}\tValue: {1:C}", inventoryCount, inventoryValue);
                            }
                            else
                            {
                                Console.WriteLine("Invalid number of disks to buy");
                            }

                            break;
                        case 3:
                            Console.Write("How many disks to you want to sell?");
                            if(int.TryParse(Console.ReadLine(), out int numberOfDisksToSell) && numberOfDisksToSell > MINIMUM_NUMBER_OF_DISKS_TO_SELL_ALLOWED)
                            {
                                //  add the number of disks to sell
                                inventoryCount += numberOfDisksToSell;

                                //  calculate the total inventory value
                                inventoryValue = inventoryCount * DISK_COST;

                                Console.WriteLine("Inventory Count: {0}\tValue: {1:C}", inventoryCount, inventoryValue);
                            }
                            else
                            {
                                Console.WriteLine("Invalid number of disks to sell");
                            }

                            break;
                        default:
                            Console.WriteLine("Thank you for Visiting");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid option, choose from (1, 2, 3, or 4)");
                }
            }
            else
            {
                Console.WriteLine("Invalid number for inventory");
            }
        }
    }
}
