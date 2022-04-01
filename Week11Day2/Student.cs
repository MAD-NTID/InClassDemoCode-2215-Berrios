using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11Day2
{
    class Student
    {
        public const string NAME_DEFAULT = "Name not Assigned";

        private string name;

        public string Name
        {
            get { return name; }
            set 
            {
                //if (string.IsNullOrEmpty(value))
                //{
                //    name = NAME_DEFAULT;
                //}
                //else
                //{
                //    name = value;
                //}

                //  Ternary operator
                name = string.IsNullOrEmpty(value) ? 
                    NAME_DEFAULT : value;
            }
        }

        private int credits;

        public int Credits
        {
            get { return credits; }
            set {
                //if (value < 0)
                //    credits = value * -1;

                credits = Math.Abs(value); 
            }
        }

        public Student() : this(NAME_DEFAULT, 0) { }

        public Student (string name, int credits)
        {
            Name = name;
            Credits = credits;
        }

        //  This gets called by default if not specified
        public override string ToString()
        {
            return $"Student Name: {name}\nNumber of Credits: {credits}";
        }
    }
}
