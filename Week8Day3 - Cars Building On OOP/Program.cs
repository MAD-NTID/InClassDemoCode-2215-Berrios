using System;

namespace Week8Day3___Cars_Building_On_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[10];

            cars[0] = new Car("Honda", "Civic", "Red", "Hatchback", false, 25000);

            Console.WriteLine(cars[0].ToString());

            cars[1] = new Car("Jeep", "Wrangler", "Red", "SUV", false, 45000, 2021);

            Console.WriteLine();
            Console.WriteLine(cars[1].ToString());

            cars[2] = new Car();
            cars[2].Manufacturer = "Subaru";
            cars[2].Model = "Impreza";
            cars[2].Color = "Blue";
            cars[2].Type = "Compact";
            cars[2].Electric = false;
            cars[2].Year = -2022;

            Console.WriteLine();
            Console.WriteLine(cars[2].ToString());

            cars[3] = new Car("Honda", "Pilot", "Black", "SUV", false, 30000, -2014);

            Console.WriteLine();
            Console.WriteLine(cars[3].ToString());
        }
    }
}
