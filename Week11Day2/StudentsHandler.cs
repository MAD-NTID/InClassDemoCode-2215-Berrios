using System;
using System.Collections.Generic;

namespace Week11Day2
{
    class StudentsHandler
    {
        private List<Student> students;

        public List<Student> StudentsList { get { return students; } }

        public StudentsHandler()
        {
            students = new();
        }

        public void AddStudent(string name, int credits)
        {
            Student student = new Student(name, credits);

            students.Add(student);
        }

        public void AddStudentByObject(Student student)
        {
            students.Add(student);
        }

        public bool RemoveStudentByName(string name)
        {
            foreach(Student student in students)
            {
                if(student.Name.ToLower() == name)
                {
                    // This will however remove only the "FIRST" occurrence
                    students.Remove(student);

                    //  Successfully deleted a student by name
                    return true;
                }
            }

            //  Could not delete anything
            return false;
        }

        public string ShowAllStudents()
        {
            string students = "";

            foreach (Student student in StudentsList)
            {
                students += student + "\n";
            }

            return students;
        }
    }
}
