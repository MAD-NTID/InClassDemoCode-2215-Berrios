using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Week12Day1_Serialization
{
    class Student
    {
        [JsonProperty("First Name")]
        public string Name { get; set; }
        [JsonProperty("Last Name")]
        public string LastName { get; set; }
        [JsonProperty("Academic Program")]
        public string Program { get; set; }
        public string Hometown { get; set; }

        public Student(string name, string lastname, string program, string hometown)
        {
            Name = name;
            LastName = lastname;
            Program = program;
            Hometown = hometown;
        }

        public override string ToString()
        {
            return $"First Name: {Name}\nLast Name: {LastName}\nProgram: {Program}\nHometown: {Hometown}";
        }
    }
}
