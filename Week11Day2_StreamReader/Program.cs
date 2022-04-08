using System;
using System.Collections.Generic;
using System.IO;

namespace Week11Day2_StreamWriter
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

            bool runProgram = true;

            CarManager carManager = new();

            while (runProgram)
            {
                Console.Write("1. Create cars\n2. Read cars\n3. Show Cars\nEnter Choice: ");

                string choice = Console.ReadLine();

                Console.WriteLine();

                switch (choice)
                {
                    case "1":

                        while (true)
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
                            Car car = new(license, make, model, year);

                            //  tell the car manager to add the new car object to your dictionary
                            carManager.AddNewCar(license, car);

                            Console.Write("\nDo you want to add another car? (y/n): ");
                            string input = Console.ReadLine().ToLower();

                            if (input != "y")
                                break;
                        }

                        carManager.Save();

                        Console.WriteLine("Thank you for using Car Manager. Buh bye!");
                        break;
                    case "2":
                        carManager.Read();

                        break;
                    case "3":
                        carManager.Show();

                        break;
                    case "4":
                        runProgram = false;

                        break;
                    default:
                        Console.WriteLine("Invalid menu choice");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
