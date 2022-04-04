using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11Day3
{
    class Car
    {
        const string MANUFACTURER_DEFAULT = "No Manufacturer", MODEL_DEFAULT = "No Model";
        const int YEAR_DEFAULT = 1769;

        private string manufacturer;

        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = string.IsNullOrEmpty(value) ? MANUFACTURER_DEFAULT : value; }
        }

        private string model;

        public string Model
        {
            get { return model; }
            set { model = string.IsNullOrEmpty(value) ? MODEL_DEFAULT : value; }
        }

        private int year;

        public int Year
        {
            get { return year; }
            set { year = value < YEAR_DEFAULT ? YEAR_DEFAULT : value ; }
        }

        public Car() : this(MANUFACTURER_DEFAULT, MODEL_DEFAULT, YEAR_DEFAULT) { }

        public Car(string manufacturer, string model, int year)
        {
            Manufacturer = manufacturer;
            Model = model;
            Year = year;
        }

        public override string ToString()
        {
            return $"Make: {manufacturer}\nModel: {model}\nYear: {year}";
        }
    }
}
