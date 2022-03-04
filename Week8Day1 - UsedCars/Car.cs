using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8Day1___UsedCars
{
    class Car
    {
        public string manufacturer;
        public string model;
        public string color;
        public string type;
        public bool electric;
        public double msrp;
        
        public Car(string _manufacturer, string _model, string _color, string _type, bool _electric, double _msrp)
        {
            manufacturer = _manufacturer;
            model = _model;
            color = _color;
            type = _type;
            electric = _electric;
            msrp = _msrp;
        }

        public override string ToString()
        {
            string toString = string.Format(
                $"Car Info: \n" +
                $"Manufacturer {manufacturer}\n" +
                $"Model {model}\n" +
                $"Color {color}\n" +
                $"Type {type}\n" +
                $"Electric {electric}\n" +
                $"MSRP {msrp:C}\n" +
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
