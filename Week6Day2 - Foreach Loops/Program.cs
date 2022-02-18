using System;

namespace Week6Day2___Foreach_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Assume All Input Are Valid
            Console.Write("How many students are in the class? ");
            string[] students = new string[int.Parse(Console.ReadLine())];
            string[] degrees = new string[students.Length];

            for (int i = 0; i < students.Length; i++)
            {
                Console.Write("What is the student's name: ");
                students[i] = Console.ReadLine();

                Console.Write("What is the student's degree: ");
                degrees[i] = Console.ReadLine();
            }

            //  THE BEST LOOP FOR ITERATING THROUGH ONE DIMENSIONAL ARRAY / PARALLELED ARRAY
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"{i + 1}: Student's name is {students[i]} and their degree is {degrees[i]}");
            }

            //  NOT THE BEST USE OF FOREACH - BUT A WORK AROUND TO SIMULATE FOR Loop
            //  PROBLEM: Array.IndexOf gives you the first occurrence - so if you have two students with the same name, this function will always give you the index of the first occurrence. Bad Bad.
            //  Array.IndexOf works best on Unique Arrays - meaning, each student has a Unique Name
            //foreach (string student in students)
            //{
            //    //  Array.IndexOf - retrieves the index from an array that matches the argument parameter
            //    //  Argumnet 1 - Array of Students
            //    //  Argument 2 - String to search in the Array of Students
            //    int currentIndex = Array.IndexOf(students, student);

            //    Console.WriteLine($"{currentIndex + 1}: Student's name is {student} and their degree is {degrees[currentIndex]}");
            //}
        }
    }
}
