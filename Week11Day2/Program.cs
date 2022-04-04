using System;
using System.Collections.Generic;

namespace Week11Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentsHandler studentsHandler = new();

            //  Predefined students
            studentsHandler.AddStudent("Menna", 17);
            studentsHandler.AddStudent("Flavio", 17);
            studentsHandler.AddStudent("Anthony", 16);
            studentsHandler.AddStudent("Vincent", 14);
            studentsHandler.AddStudent("Evan", 16);
            studentsHandler.AddStudent("Amir", 0);
            studentsHandler.AddStudent("Edwin", 2);

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

                studentsHandler.AddStudentByObject(newStudent);

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

            Console.WriteLine(studentsHandler.ShowAllStudents());

            //  Remove a student by name
            while(true)
            {
                Console.Write("Do you want to delete a student? Enter the name, 'n' to exit: ");

                string studentNameInput = Console.ReadLine().ToLower();

                if (studentNameInput == "n")
                    break;
                else
                {
                    //  We search for a match in the Students' ArrayList
                    studentsHandler.RemoveStudentByName(studentNameInput);

                    Console.WriteLine(studentsHandler.ShowAllStudents());
                }
            }
        }
    }
}
