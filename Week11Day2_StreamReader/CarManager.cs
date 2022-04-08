using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11Day2_StreamWriter
{
    class CarManager
    {
        //  Don't forget to replace ??? with your computer's Home username
        const string FILE_PATH = @"C:\Users\mxbics\Desktop\MyCars.txt";
        //const string DIRECTORY_TO_SAVE = "/Users/???/Desktop/MyCars.txt";

        private Dictionary<string, Car> myCars;

        public Dictionary<string, Car> MyCars { get { return myCars; } }

        public CarManager()
        {
            myCars = new Dictionary<string, Car>();
        }

        public void AddNewCar(string license, Car car)
        {
            if(!myCars.ContainsKey(license))
                myCars.Add(license, car);
            else
                Console.WriteLine($"A car with that license {license} plate already exists");
        }

        public void Save()
        {
            using(StreamWriter carWriter = new(FILE_PATH))
            {
                foreach (KeyValuePair<string, Car> car in myCars)
                {
                    carWriter.WriteLine(car.Value.ToStringForFile() + "\n");
                    carWriter.Flush();
                }
            }
        }

        public void Read()
        {
            if(File.Exists(FILE_PATH))
            {
                //  Basic and Manual way of handling StreamReader
                //StreamReader carReader = new(FILE_PATH);

                //Console.WriteLine("Yay, file was found");

                //carReader.Close();

                using (StreamReader carReader = new(FILE_PATH))
                {
                    //  The temporary dictionary to hold the loaded cars
                    Dictionary<string, Car> loadedCars = new Dictionary<string, Car>();

                    while(!carReader.EndOfStream)
                    {
                        string line = carReader.ReadLine();

                        if(!string.IsNullOrEmpty(line))
                        {
                            string license, make, model;
                            int year;

                            //  split the line details by delimeter | (pipe)
                            string[] carDetails = line.Split(Car.SEPARATOR);

                            //  This is the manual way! You need to know 
                            license = carDetails[0];
                            make = carDetails[1];
                            model = carDetails[2];
                            year = int.Parse(carDetails[3]);

                            //  create a car object from the details obtained from file
                            Car car = new(license, make, model, year);

                            //  add the car object to the temporary dictionary
                            loadedCars.Add(license, car);
                        }
                    }

                    //  replace the Car Manager Dictionary with the loaded cars' dictionary only if the temporary car dictionary has cars in it
                    int carsFound = loadedCars.Count;
                    
                    if (carsFound > 0)
                    {
                        Console.WriteLine($"{carsFound} {(carsFound == 1 ? "car was" : "cars were")} loaded");

                        myCars = loadedCars;
                    }
                }
            }
            else
            {
                Console.WriteLine("Sorry, that file was not found");
            }
        }

        public void Show()
        {
            int counter = 0;

            foreach (KeyValuePair<string, Car> car in MyCars)
                Console.WriteLine($"{++counter}. {car.Value}");
        }
    }
}
