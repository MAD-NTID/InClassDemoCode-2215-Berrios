using System;

namespace Week7Day1___Car_Information_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Collect car information and print details based on car's name by using a switch or if/else if/else statements
            //  The purpose of this problem is to show how useful methods are

            string[] carBrands = { "BMW", "Toyota", "Honda" };
            string[] carDetails =
            {
                "Fancy Luxury Cars - Usually expensive to maintain. And expensive insurance policy. Expensive. Piece of Junk",
                "Typical Japanese Brand - Usually affordable. Cost effective on gas and policy. Great cars",
                "Fancier than Toyota - But usually higher techs. Cost effective on gas and policy. Awesome cars"
            };

            Console.Write($"Enter a car brand from the following to get more details\n {carBrands[0]}, {carBrands[1]}, {carBrands[2]}: ");

            switch(Console.ReadLine())
            {
                case "BMW":
                    PrintCarDetail(carDetails[0]);

                    break;
                case "Toyota":
                    PrintCarDetail(carDetails[1]);

                    break;
                case "Honda":
                    PrintCarDetail(carDetails[2]);

                    break;
                default:
                    InvalidSelection();

                    break;
            }
        }

        public static void PrintCarDetail(string details)
        {
            Console.WriteLine(details);
        }

        public static void InvalidSelection()
        {
            Console.WriteLine("Unknown selection");
        }
    }
}
