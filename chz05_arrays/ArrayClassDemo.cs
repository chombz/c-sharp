using System;

namespace chz05_arrays
{
    /// <summary>
    /// C# program that demonstrates some methods and properties of the Array class
    /// </summary>
    class ArrayClassDemo
    {
        static void Main(string[] args)
        {
            //create single dimensional array
            Array courses = Array.CreateInstance(typeof(string), 5);
            courses.SetValue("Information Technology", 3);
            courses.SetValue("Marketing", 0);
            courses.SetValue("Human Resource", 2);
            courses.SetValue("Business Admin", 4);
            courses.SetValue("Finance", 1);

            //Diplay courses using for...each loop
            foreach (string course in courses)
            {
                Console.WriteLine(courses);
            }

            //Display the courses
            for (int e = 0; e <= courses.GetUpperBound(0); e++)
            {
                Console.WriteLine($"Course {(e+1):)}: {courses.GetValue(e)}");
            }

            //Create a multi-dimension array
            Array empDetails = Array.CreateInstance(typeof(string), 2, 3);
            empDetails.SetValue("141", 0, 0);
            empDetails.SetValue("147", 0, 1);
            empDetails.SetValue("154", 0, 2);
            empDetails.SetValue("Joan Fuller", 1, 0);
            empDetails.SetValue("Barbara Boxen", 1, 1);
            empDetails.SetValue("Paul Smith", 1, 2);

            Console.WriteLine("Employee ID \tName");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(empDetails.GetValue(i, j) + "\t\t ");
                }
                Console.WriteLine();//Move to a new line for each employee
            }

            Console.WriteLine($"Rank of courses of array: {courses.Rank}"
                             + $"\nRank of empDetails array: {empDetails.Rank}");
        }
    }
}
