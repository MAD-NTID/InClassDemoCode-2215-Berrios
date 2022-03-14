using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8Day3___Cars_Building_On_OOP
{
    class Car
    {
        const int YEAR_FIRST_CAR_MADE = 1886;

        private string manufacturer;

        public string Manufacturer {
            get { return manufacturer; } 
            set
            {
                manufacturer = value;
            }
        }

        private string model;
        public string Model { 
            get { return model;  } 
            set { model = value; } 
        }

        private int year;
        public int Year { 
            get { return year; }
            set 
            { 
                //  First rule validates for negative
                if(value < 0)
                {
                    value = Math.Abs(value);
                }

                //  Validates year is not less than the first car ever created
                if(value < YEAR_FIRST_CAR_MADE)
                {
                    value = YEAR_FIRST_CAR_MADE;
                }

                year = value; 
            } 
        }

        private string color;
        public string Color { 
            get { return color; } 
            set { color = value; } 
        }

        private string type;
        public string Type { get { return type;  } set { type = value; } }

        private bool electric;

        public bool Electric { get { return electric;  } set { electric = value; } }

        private double msrp;

        public double MSRP { get { return msrp; } set { msrp = value; } }

        ////  The default constructor
        ////  No parameters
        //public Car()
        //{
        //    manufacturer = "N/A";
        //    model = "N/A";
        //    color = "N/A";
        //    type = "N/A";
        //    electric = false; // meaning gas
        //    msrp = 0;
        //}

        //  The Default constructor
        //  Sets the default values if not provided to the constructor
        public Car() : this("N/A", "N/A", "N/A", "N/A", false, 0, YEAR_FIRST_CAR_MADE) { }

        //  This is a parametarized Constructor 
        //  Meaning, it takes in parameters values
        public Car(string _manufacturer, string _model, string _color, string _type, bool _electric, double _msrp, int _year)
        {
            manufacturer = _manufacturer;
            model = _model;
            color = _color;
            type = _type;
            electric = _electric;
            msrp = _msrp;
            Year = _year;
        }

        public Car(string _manufacturer, string _model, string _color, string _type, bool _electric, double _msrp)
        {
            manufacturer = _manufacturer;
            model = _model;
            color = _color;
            type = _type;
            electric = _electric;
            msrp = _msrp;
            year = DateTime.Now.Year;
        }

        public override string ToString()
        {
            string toString = string.Format(
                $"Car Info \n" +
                $"Manufacturer: {manufacturer}\n" +
                $"Model: {model}\n" +
                $"Year: {year}\n" +
                $"Color: {color}\n" +
                $"Type: {type}\n" +
                $"Electric: {electric}\n" +
                $"MSRP: {msrp:C}\n" +
                $"Monthly for 72 Months {MonthlyPaymentSeventyTwoMonths():C}"
                );

            return toString;
        }

        public void StarEngine()
        {
            Console.WriteLine("Vroom vroom vroom");
        }

        public void ShutOffEngine()
        {
            Console.WriteLine("Dururtoo too too... (silent)");
        }

        public double MonthlyPaymentSeventyTwoMonths()
        {
            return msrp / 72;
        }
    }
}
