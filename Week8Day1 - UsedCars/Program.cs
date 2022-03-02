using System;

namespace Week8Day1___UsedCars
{
    class Program
    {
        static void Main(string[] args)
        {
            //  creates an array of Car
            Car[] cars = new Car[2];

            //  New Instance of a Car with Values added to cars array index 0
            Car theCar = new Car("Tesla", "Model S", "Gray", "Sedan", true, 45000);
            cars[0] = theCar;

            //  New Instance of a Car with Values added to cars array index 1
            Car theCar2 = new Car("Subaru", "Impreza", "Blue", "Senda", false, 20000);
            cars[1] = theCar2;

            //  Show car details for each Car in the cars array
            for(int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine($"Car {i + 1}");
                cars[i].ShowCarDetails();
                Console.WriteLine();
            }
        }
    }
}
