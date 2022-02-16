using System;

namespace Week6Day1___For_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //const int NUMBER_OF_STUDENTS = 9;

            //string[] students = new string[NUMBER_OF_STUDENTS];

            //  Prompt the user to enter the names of each students
            //  Assume data is validated
            #region The Loopy Way
            Console.Write("How many students do you want to roster: ");
            int numberOfStudents = int.Parse(Console.ReadLine());

            string[] students = new string[numberOfStudents];

            for(int index = 0; index < numberOfStudents; index++)
            {
                Console.Write($"Please enter student {index + 1}. name: ");
                students[index] = Console.ReadLine();
            }

            Console.WriteLine("The Student Roster Is: ");

            for (int index = 0; index < students.Length; index++)
            {
                Console.WriteLine($"{index + 1}. {students[index]}");
            }
            #endregion

            #region The Manual Way
            //Console.Write("Please enter student 1 name: ");
            //students[0] = Console.ReadLine();

            //Console.Write("Please enter student 2 name: ");
            //students[1] = Console.ReadLine();

            //Console.Write("Please enter student 3 name: ");
            //students[2] = Console.ReadLine();

            //Console.Write("Please enter student 4 name: ");
            //students[3] = Console.ReadLine();

            //Console.Write("Please enter student 5 name: ");
            //students[4] = Console.ReadLine();

            //Console.Write("Please enter student 6 name: ");
            //students[5] = Console.ReadLine();

            //Console.Write("Please enter student 7 name: ");
            //students[6] = Console.ReadLine();

            //Console.Write("Please enter student 8 name: ");
            //students[7] = Console.ReadLine();

            //Console.Write("Please enter student 9 name: ");
            //students[8] = Console.ReadLine();

            //Console.WriteLine("The Student Roster Is: \n" +
            //    $"1. {students[0]}\n" +
            //    $"2. {students[1]}\n" +
            //    $"3. {students[2]}\n" +
            //    $"4. {students[3]}\n" +
            //    $"5. {students[4]}\n" +
            //    $"6. {students[5]}\n" +
            //    $"7. {students[6]}\n" +
            //    $"8. {students[7]}\n" +
            //    $"9. {students[8]}\n");
            #endregion
        }
    }
}
