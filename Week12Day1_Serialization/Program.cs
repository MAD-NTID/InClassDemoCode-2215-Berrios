using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;


namespace Week12Day1_Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            const string FILE_NAME = "students.json";

            List<Student> students = new();

            students.Add(new Student("Michael", "Berrios", "IT", "Bronx, NY"));
            students.Add(new Student("Menna", "Nicola", "ACT", "Austin, TX"));
            students.Add(new Student("Anthony", "Caccese", "ACT", "NJ"));
            students.Add(new Student("Vincent", "Son", "ACT", "TX"));
            students.Add(new Student("Evan", "Snyder", "ACT", "OH"));
            students.Add(new Student("Amir", "Elias", "ACT", "NJ"));
            students.Add(new Student("Edwin", "Inga", "ACT", "NY"));

            string jsonString = JsonConvert.SerializeObject(students);

            using (StreamWriter writer = new(FILE_NAME))
            {
                writer.WriteLine(jsonString);
            }

            Console.WriteLine("Students has been written to file");

            using (StreamReader reader = new(FILE_NAME))
            {
                jsonString = reader.ReadToEnd();

                students = JsonConvert.DeserializeObject<List<Student>>(jsonString);
            }

            // for each Student in the students List assign to local
            //  variable student
            foreach (Student student in students)
            {
                Console.WriteLine(student);
                Console.WriteLine();
            }
        }
    }
}
