using System;
using System.Collections.Generic;

namespace Week11Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            Students students = new();

            //  Predefined students
            students.AddStudent("Menna", 17);
            students.AddStudent("Flavio", 17);
            students.AddStudent("Anthony", 16);
            students.AddStudent("Vincent", 14);
            students.AddStudent("Evan", 16);
            students.AddStudent("Amir", 0);
            students.AddStudent("Edwin", 2);

            //  Add a new student
            Student newStudent;

            bool continueStudent = true;

            while(continueStudent)
            {
                newStudent = new();

                //  Get student name
                while (true)
                {
                    Console.Write("Enter a new student name: ");
                    newStudent.Name = Console.ReadLine();

                    if (newStudent.Name == Student.NAME_DEFAULT)
                    {
                        Console.WriteLine("Invalid Student Name");
                    }
                    else
                    {

                        break;
                    }
                }

                //  Get student credits
                while(true)
                {
                    Console.Write("Enter the new student's credits: ");
                    
                    if(int.TryParse(Console.ReadLine(), out int credits))
                    {
                        newStudent.Credits = credits;

                        break;
                    }
                    else
                        Console.WriteLine("Invalid input");
                }

                students.AddStudentByObject(newStudent);

                while(true)
                {
                    Console.Write("Add more students (y/n): ");

                    string input = Console.ReadLine().ToLower();

                    if (input == "y")
                    {
                        continueStudent = true;

                        break;
                    }
                    else if(input == "n")
                    {
                        continueStudent = false;

                        break;
                    }
                    else
                    {
                        Console.WriteLine("Unknown response");
                    }
                }
            }

            foreach(Student student in students.StudentsList)
            {
                Console.WriteLine(student);
                Console.WriteLine();
            }
        }
    }
}
