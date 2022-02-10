using System;

namespace Week4Day3MockExam1_WingsHeaven_Simple
{
    class Program
    {
        static void Main(string[] args)
        {
            //order type
            const double BONELESS_WINGS = 7.99;
            const double TRADATIONAL_WINGS = 9.99;
            const double BOTH_WINGS = 17.98;
            const double DISCOUNT_RATE = 0.18;
            const double TAX_RATE = .08;

            //sauce type
            const double BUFFALO_SAUCE = .29;
            const double MILD_SAUCE = .39;
            const double BBQ_SAUCE = .29;

            //sides
            const double FRIES = 3.49;
            const double RINGS = 2.49;
            const double BOTH_SIDES = 5.98;

            //options
            const int OPTION_ONE = 1;
            const int OPTION_TWO = 2;
            const int OPTION_THREE = 3;
            const int OPTION_FOUR = 4;

            Console.WriteLine("*** HEAVEANLY WINGS ***");
            Console.WriteLine();
            Console.WriteLine("Type of wings:");
            Console.WriteLine("\t{0,-20} {1,20:C}", "1.Boneless", BONELESS_WINGS);
            Console.WriteLine("\t{0,-20} {1,20:C}", "2.Tradational", TRADATIONAL_WINGS);
            Console.WriteLine("\t{0,-20} {1,20:C}", "3.Both", BOTH_WINGS);

            Console.Write("Enter your selection:");
            int selection = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("What kind of sauce?");
            Console.WriteLine("\t{0,-20} {1,20:C}", "1.Buffalo Sauce", BUFFALO_SAUCE);
            Console.WriteLine("\t{0,-20} {1,20:C}", "2.Mild Sauce", MILD_SAUCE);
            Console.WriteLine("\t{0,-20} {1,20:C}", "3.BBQ Sauce", BBQ_SAUCE);
            Console.WriteLine("\t{0,-20} {1,20:C}", "4.Plain Sauce", "No Charge");
            int sauce = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Do you want a side order?");
            Console.WriteLine("\t{0,-20} {1,20:C}", "1.Waffle Fries", FRIES);
            Console.WriteLine("\t{0,-20} {1,20:C}", "2.Onion Rings", RINGS);
            Console.WriteLine("\t{0,-20} {1,20:C}", "3.Both", BOTH_SIDES);
            int sides = int.Parse(Console.ReadLine());

            //printing the receipt
            double total = 0;
            Console.WriteLine("*** HEAVENLY WINGS ***");
            switch (selection)
            {
                case OPTION_ONE:
                    Console.WriteLine($"Boneless Wings {BONELESS_WINGS:C}");
                    total += BONELESS_WINGS;
                    break;
                case OPTION_TWO:
                    Console.WriteLine($"Tradational Wings {TRADATIONAL_WINGS:C}");
                    total += TRADATIONAL_WINGS;
                    break;
                case OPTION_THREE:
                    Console.WriteLine($"Both Wings {BOTH_SIDES:C}");
                    double discount = BOTH_WINGS * DISCOUNT_RATE;
                    Console.WriteLine($"Discount(18%) {discount:C}");
                    total += (BOTH_WINGS - discount);
                    break;
            }

            switch (sauce)
            {
                case OPTION_ONE:
                    total += BUFFALO_SAUCE;
                    Console.WriteLine($"Buffalo Sauce {BUFFALO_SAUCE:C}");
                    break;
                case OPTION_TWO:
                    total += MILD_SAUCE;
                    Console.WriteLine($"Mild Sauce {MILD_SAUCE:C}");
                    break;
                case OPTION_THREE:
                    total += BBQ_SAUCE;
                    Console.WriteLine($"BBQ Sauce {BBQ_SAUCE:C}");
                    break;
                case OPTION_FOUR:
                    Console.WriteLine($"Plain Sauce No Charge");
                    break;

            }

            switch (sides)
            {
                case OPTION_ONE:
                    total += FRIES;
                    Console.WriteLine($"Waffle Fries {FRIES:C}");
                    break;
                case OPTION_TWO:
                    total += RINGS;
                    Console.WriteLine($"Onion Rings {RINGS:C}");
                    break;
                case OPTION_THREE:
                    total += BOTH_SIDES;
                    Console.WriteLine($"Waffle Fries & Onion Rings {BOTH_SIDES:C}");
                    break;
            }

            Console.WriteLine("Subtotal: {0:C}", total);
            Console.WriteLine($"Tax: {total * TAX_RATE:C}");
            
            total += (TAX_RATE * total);
            
            Console.WriteLine($"Total: {total:C}");
        }
    }
}
