using System;
using System.Collections.Generic;

namespace Week11Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Car> registeredCars = new Dictionary<string, Car>();

            Car flavioCar = new Car("Subaru", "Impreza", 2018);
            registeredCars.Add("fcs1234", flavioCar);

            Car evanCar = new Car("Honda", "Pilot", 2014);
            registeredCars.Add("ech1234", evanCar);

            Car edwinCar = new Car("Dodge", "Challenger", 2015);
            registeredCars.Add("ecd1234", edwinCar);

            #region Creating a new Car object into the Dictionary
            while (true)
            {
                Console.Write("Enter the make of the car: ");
                string make = Console.ReadLine();

                //  Validate the Make
                if(!string.IsNullOrEmpty(make))
                {
                    while(true)
                    {
                        Console.Write("Enter the model of the car: ");
                        string model = Console.ReadLine();

                        //  Validate the Model
                        if(!string.IsNullOrEmpty(model))
                        {
                            while(true)
                            {
                                //  Validate the Year is Int
                                Console.Write("Enter the year of the car: ");
                                if(int.TryParse(Console.ReadLine(), out int year))
                                {
                                    while(true)
                                    {
                                        Console.Write("Enter the license plate: ");
                                        string license = Console.ReadLine();

                                        //  Validate the License
                                        if(!string.IsNullOrEmpty(license))
                                        {
                                            //  Create the Car object, add to the Dictionary, and break out of the loop
                                            Car newCar = new Car(make, model, year);

                                            if(!registeredCars.ContainsKey(license))
                                                registeredCars.Add(license, newCar);
                                            else
                                                Console.WriteLine("Sorry, that car's license plate already exists");

                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid License Plate");
                                        }
                                    }

                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid car year");
                                }
                            }

                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Model");
                        }
                    }

                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Make");
                }
            }
            #endregion

            foreach (KeyValuePair<string, Car> currentCar in registeredCars)
            {
                Console.WriteLine($"License Plate: {currentCar.Key}"); // is the key we assigned
                Console.WriteLine(currentCar.Value);    // will call ToString()
                Console.WriteLine();
            }

            #region Deleting a Car object from the dictionary
            while (true)
            {
                Console.Write("Do you want to delete a car? Enter the license plate (enter 'n' to exit'): ");
                string licensePlate = Console.ReadLine();

                if (licensePlate.ToLower() == "n")
                    break;
                else if (!string.IsNullOrEmpty(licensePlate) && registeredCars.ContainsKey(licensePlate))
                {
                    registeredCars.Remove(licensePlate);

                    break;
                }
                else
                {
                    Console.WriteLine("Invalid License Plate");
                }
            }
            #endregion

            foreach (KeyValuePair<string, Car> currentCar in registeredCars)
            {
                Console.WriteLine($"License Plate: {currentCar.Key}"); // is the key we assigned
                Console.WriteLine(currentCar.Value);    // will call ToString()
                Console.WriteLine();
            }

            #region Updating a Car object from the dictionary
            while (true)
            {
                Console.Write("Do you want to update a car? Enter the license plate (enter 'n' to exit'): ");
                string licensePlate = Console.ReadLine();

                if (licensePlate.ToLower() == "n")
                    break;
                else if (!string.IsNullOrEmpty(licensePlate) && registeredCars.ContainsKey(licensePlate))
                {
                    while (true)
                    {
                        Console.Write("Enter the make of the car: ");
                        string make = Console.ReadLine();

                        //  Validate the Make
                        if (!string.IsNullOrEmpty(make))
                        {
                            while (true)
                            {
                                Console.Write("Enter the model of the car: ");
                                string model = Console.ReadLine();

                                //  Validate the Model
                                if (!string.IsNullOrEmpty(model))
                                {
                                    while (true)
                                    {
                                        //  Validate the Year is Int
                                        Console.Write("Enter the year of the car: ");
                                        if (int.TryParse(Console.ReadLine(), out int year))
                                        {
                                            Car updatedCar = new Car(make, model, year);

                                            registeredCars[licensePlate] = updatedCar;

                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid car year");
                                        }
                                    }

                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Model");
                                }
                            }

                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Make");
                        }
                    }

                    break;
                }
                else
                {
                    Console.WriteLine("Invalid License Plate");
                }
            }
            #endregion

            foreach (KeyValuePair<string, Car> currentCar in registeredCars)
            {
                Console.WriteLine($"License Plate: {currentCar.Key}"); // is the key we assigned
                Console.WriteLine(currentCar.Value);    // will call ToString()
                Console.WriteLine();
            }
            //if(registeredCars.TryGetValue("fcs1234", out Car flavioRegisteredCar))
            //{
            //    Console.WriteLine(flavioRegisteredCar); ;
            //}
            //else
            //{
            //    Console.WriteLine("Sorry, that car was not found in the registry");
            //}
        }
    }
}
