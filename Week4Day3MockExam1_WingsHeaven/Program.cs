using System;

namespace Week4Day3MockExam1_WingsHeaven
{
    class Program
    {
        static void Main(string[] args)
        {
            const string BUSINESS_NAME = "Heavenly Wings";

            const double BONESLESS_PRICE = 7.99, TRADITIONAL_PRICE = 9.99, BOTH_WINGS_PRICE = 17.98;
            
            const double WINGS_DISCOUNT = .18;

            const double BUFFALO_PRICE = .29, MILD_PRICE = .39, BBQ_PRICE = .29, PLAIN_PRICE = 0;

            const double WAFFLE_FRIES_PRICE = 3.49, ONION_RINGS_PRICE = 2.49, BOTH_SIDES_PRICE = 5.98;

            const double NYS_TAX_RATE = .08;

            Console.WriteLine($"***{BUSINESS_NAME}***\n");

            Console.Write("Type of Wings:\n" +
                $"\t1. Boneless {BONESLESS_PRICE:C}\n" +
                $"\t2. Traditional {TRADITIONAL_PRICE:C}\n" +
                $"\t3. Both {BOTH_WINGS_PRICE:C}\n" +
                $"Enter your selection: ");

            string wingsOption = Console.ReadLine();

            if(wingsOption == "1" || wingsOption == "2" || wingsOption == "3")
            {
                string wingsSelected;
                double wingsSelectedPrice;

                switch(wingsOption)
                {
                    case "1":
                        wingsSelected = "Boneless";
                        wingsSelectedPrice = BONESLESS_PRICE;
                        break;
                    case "2":
                        wingsSelected = "Traditional";
                        wingsSelectedPrice = TRADITIONAL_PRICE;
                        break;
                    default:
                        wingsSelected = $"Both Wings\n\tDiscount ({WINGS_DISCOUNT:P})";
                        wingsSelectedPrice = BOTH_WINGS_PRICE - (BOTH_WINGS_PRICE * WINGS_DISCOUNT);
                        break;
                }

                Console.Write("\nWhat kind of sauce?\n" +
                    $"\t1. Buffalo Sauce {BUFFALO_PRICE:C}\n" +
                    $"\t2. Mild Sauce {MILD_PRICE:C}\n" +
                    $"\t3. BBQ Sauce {BBQ_PRICE:C}\n" +
                    $"\t4. Plain {PLAIN_PRICE:C}\n" +
                    $"Enter your selection: ");

                string sauceOption = Console.ReadLine();

                if(sauceOption == "1" || sauceOption == "2" || sauceOption == "3" || sauceOption == "4")
                {
                    string sauceSelected;
                    double sauceSelectedPrice;

                    switch(sauceOption)
                    {
                        case "1":
                            sauceSelected = "Buffalo Sauce";
                            sauceSelectedPrice = BUFFALO_PRICE;
                            break;

                        case "2":
                            sauceSelected = "Mild Sauce";
                            sauceSelectedPrice = MILD_PRICE;
                            break;

                        case "3":
                            sauceSelected = "BBQ Sauce";
                            sauceSelectedPrice = BBQ_PRICE;
                            break;

                        default:
                            sauceSelected = "Plain";
                            sauceSelectedPrice = PLAIN_PRICE;
                            break;
                    }

                    Console.Write("\nWhich side order do you want?\n" +
                        $"\t1. Waffle Fries {WAFFLE_FRIES_PRICE:C}\n" +
                        $"\t2. Onion Rings {ONION_RINGS_PRICE:C}\n" +
                        $"\t3. Both {BOTH_SIDES_PRICE:C}\n" +
                        $"Enter your selection: ");

                    string sideOption = Console.ReadLine();

                    if(sideOption == "1" || sideOption == "2" || sideOption == "3")
                    {
                        string sideSelected;
                        double sideSelectedPrice;

                        switch(sideOption)
                        {
                            case "1":
                                sideSelected = "Waffle Fries";
                                sideSelectedPrice = WAFFLE_FRIES_PRICE;

                                break;
                            case "2":
                                sideSelected = "Onion Rings";
                                sideSelectedPrice = ONION_RINGS_PRICE;

                                break;
                            default:
                                sideSelected = "Both";
                                sideSelectedPrice = BOTH_SIDES_PRICE;
                                break;
                        }

                        //  Now we have all the data collected, we perform calculation and show receipt
                        double subtotal = wingsSelectedPrice + sauceSelectedPrice + sideSelectedPrice;
                        double tax = subtotal * NYS_TAX_RATE;
                        double total = subtotal + tax;

                        Console.WriteLine($"***{BUSINESS_NAME}***");
                        Console.Write($"{wingsSelected} {wingsSelectedPrice:C}\n" +
                            $"{sauceSelected} {sauceSelectedPrice:C}\n" +
                            $"{sideSelected} {sideSelectedPrice:C}\n" +
                            $"\tSubtotal: {subtotal:C}\n" +
                            $"\tTax: {tax:C}\n" +
                            $"\tTotal: {total:C}");

                        Console.WriteLine("\n\nThank you");
                    }
                    else
                    {
                        Console.WriteLine("Invalid side option");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid sauce option");
                }
            }
            else
            {
                Console.WriteLine("Invalid wings option");
            }
        }
    }
}
