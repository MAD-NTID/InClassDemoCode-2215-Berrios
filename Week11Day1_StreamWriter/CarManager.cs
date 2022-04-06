using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11Day1_StreamWriter
{
    class CarManager
    {
        //  Don't forget to replace ??? with your computer's Home username
        const string DIRECTORY_TO_SAVE = "C:\\Users\\???\\Desktop\\MyCars.txt";
        //const string DIRECTORY_TO_SAVE = "/Users/???/Desktop/MyCars.txt";

        private Dictionary<string, Car> myCars;

        public CarManager()
        {
            myCars = new Dictionary<string, Car>();
        }

        public void AddNewCar(string license, Car car)
        {
            myCars.Add(license, car);
        }

        public void Save()
        {
            using(StreamWriter carWriter = new(DIRECTORY_TO_SAVE))
            {
                foreach (KeyValuePair<string, Car> car in myCars)
                {
                    carWriter.WriteLine(car.Value + "\n");
                    carWriter.Flush();
                }
            }
        }
    }
}
