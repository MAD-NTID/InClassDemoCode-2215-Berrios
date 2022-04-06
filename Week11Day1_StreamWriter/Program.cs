using System;
using System.IO;

namespace Week11Day1_StreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            #region The Very Basic of StreamWriter
            //StreamWriter writer = new StreamWriter("C:\\Users\\mxbics\\Desktop\\MyListOfCars.txt");

            //Car myCar = new Car("Honda", "Civic", 1994);

            //writer.WriteLine(myCar);

            //writer.Close();
            #endregion

            CarManager carManager = new();

            while(true)
            {
                Console.Write("Enter the make of the car: ");
                string make = Console.ReadLine();

                Console.Write("Enter the model of the car: ");
                string model = Console.ReadLine();

                Console.Write("Enter the year of the car: ");
                int year = int.Parse(Console.ReadLine());

                Console.Write("Enter the license plate: ");
                string license = Console.ReadLine();

                //  creates the new car object from user input information
                Car car = new(make, model, year);

                //  tell the car manager to add the new car object to your dictionary
                carManager.AddNewCar(license, car);
                
                Console.Write("Do you want to add another car? (y/n): ");
                string input = Console.ReadLine().ToLower();

                if (input != "y")
                    break;
            }

            carManager.Save();

            Console.WriteLine("Thank you for using Car Manager. Buh bye!");
        }
    }
}
