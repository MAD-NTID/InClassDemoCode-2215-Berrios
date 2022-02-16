using System;

namespace Week6Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            const string BUSINESS_NAME = "Lands Beginning";
            const int NUMBER_OF_ITEMS = 4;
            const double SALES_TAX_RATE = .08;

            string[] items = new string[NUMBER_OF_ITEMS];
            double[] prices = new double[NUMBER_OF_ITEMS];

            items[0] = "Ski Jacket";
            items[1] = "Ski Pants";
            items[2] = "Cargo Shorts";
            items[3] = "Printed T-Shirt";

            prices[0] = 129.5;
            prices[1] = 85.9;
            prices[2] = 57.95;
            prices[3] = 30.75;

            Console.WriteLine($"*** {BUSINESS_NAME} ***");

            Console.WriteLine("Items\t\t\tPrices\n");
            Console.WriteLine($"1. {items[0]}\t\t{prices[0]:C}\n" +
                $"2. {items[1]}\t\t{prices[1]:C}\n" +
                $"3. {items[2]}\t\t{prices[2]:C}\n" +
                $"4. {items[3]}\t\t{prices[3]:C}\n\n");

            Console.Write("Select an item to purchase: ");
            if(int.TryParse(Console.ReadLine(), out int selection) && selection >= 1 && selection <= NUMBER_OF_ITEMS)
            {
                selection--;    // make it 0 based

                Console.Write("How many items do you want to purchase: ");

                if(int.TryParse(Console.ReadLine(), out int numberOfItemsToPurchase) && numberOfItemsToPurchase > 0)
                {
                    //  read to calculate and stuffs
                    double subtotal = prices[selection] * numberOfItemsToPurchase;
                    double tax = subtotal * SALES_TAX_RATE;
                    double total = subtotal + tax;

                    Console.WriteLine($"--- {items[selection]} ---");
                    Console.WriteLine($"Quantity: {numberOfItemsToPurchase}\n" +
                        $"Cost: {subtotal:C}\n" +
                        $"Tax: {tax:C}\n" +
                        $"Total: {total:C}");
                }
                else
                {
                    Console.WriteLine("Invalid number of items to purchase");
                }
            }
            else
            {
                Console.WriteLine($"Invalid selection. Select from 1 to {NUMBER_OF_ITEMS}");
            }
        }
    }
}
