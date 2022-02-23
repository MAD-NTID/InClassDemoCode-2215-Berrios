using System;

namespace Week7Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Collect every student's name, but, don't prompt the same code for each student, use a method

            //  Ask the user how many students they would like to store in an array
            Console.Write("How many students do you want to create? ");
            int numberOfStudents = int.Parse(Console.ReadLine());

            string[] students = new string[numberOfStudents];

            for(int i = 0; i < students.Length; i++)
            {
                students[i] = CollectStudentName();
            }
            
            //  call the method to print out the names
            PrintStudentNames(students);
        }

        public static string CollectStudentName()
        {
            Console.Write("Please enter the student's name: ");
            return Console.ReadLine();
        }

        //  a method which takes in a string array of students
        //  it doesn't return anything
        //  simply output the names for each student
        public static void PrintStudentNames(string[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {students[i]}");
            }
        }
    }
}
