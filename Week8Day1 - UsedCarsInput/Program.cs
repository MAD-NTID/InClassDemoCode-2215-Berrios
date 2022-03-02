using System;

namespace Week8Day1___UsedCarsInput
{
    class Program
    {
        static void Main(string[] args)
        {
            //  creates an array of Car
            Car[] cars = new Car[3];

            //  New Instance of a Car with Values added to cars array index 0
            Car theCar = new Car("Tesla", "Model S", "Gray", "Sedan", true, 45000);
            cars[0] = theCar;

            //  New Instance of a Car with Values added to cars array index 1
            Car theCar2 = new Car("Subaru", "Impreza", "Blue", "Senda", false, 20000);
            cars[1] = theCar2;

            Console.WriteLine("\nCreate Car with User Input\n");

            Console.Write("What is the Manufacturer:");
            string manufacturer = Console.ReadLine();

            Console.Write("What is the Model: ");
            string model = Console.ReadLine();

            Console.Write("What is the Color: ");
            string color = Console.ReadLine();

            Console.Write("What type of Car: ");
            string type = Console.ReadLine();

            Console.Write("Is it electric: ");
            bool electric = Console.ReadLine() == "yes";

            Console.Write("What is the MSRP: ");
            double msrp = double.Parse(Console.ReadLine());

            Car theCar3 = new Car(manufacturer, model, color, type, electric, msrp);
            cars[2] = theCar3;

            //  Show car details for each Car in the cars array
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine($"Car {i + 1}");
                cars[i].ShowCarDetails();
                Console.WriteLine();
            }
        }
    }
}
