using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11Day2_StreamWriter
{
    class Car
    {
        const int SPACER = -10;
        public const string SEPARATOR = "|";
        const string LICENSE_DEFAULT = "No License", MANUFACTURER_DEFAULT = "No Manufacturer", MODEL_DEFAULT = "No Model";
        const int YEAR_DEFAULT = 1769;

        private string license;

        public string License {
            get { return license; }
            set { license = string.IsNullOrEmpty(value) ? LICENSE_DEFAULT : value; }
        }

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

        public Car() : this(LICENSE_DEFAULT, MANUFACTURER_DEFAULT, MODEL_DEFAULT, YEAR_DEFAULT) { }

        public Car(string license, string manufacturer, string model, int year)
        {
            License = license;
            Manufacturer = manufacturer;
            Model = model;
            Year = year;
        }

        public string ToStringForFile()
        {
            return $"{license}{SEPARATOR}{manufacturer}{SEPARATOR}{model}{SEPARATOR}{year}";
        }

        public override string ToString()
        {
            return $"License: {license, SPACER}Make: {manufacturer, SPACER}Model: {model, SPACER}Year: {year, SPACER}";
        }
    }
}
