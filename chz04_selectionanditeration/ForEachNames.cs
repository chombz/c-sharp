using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chz04_selectionanditeration
{
    /// <summary>
    /// C# program that uses the for...each loop to display the names of students
    /// in a class
    /// </summary>
    class ForEachNames
    {
        static void Main(string[] args)
        {
            //a string array for student names
            string[] studentNames = {"Micheal", "Frank", "Edwin", "Osuma", "Farhiya" };

            //Display the names of the students using a for...each loop
            Console.WriteLine("The names of the students in the class are: ");

            int e = 1;//variable
            foreach (string name in studentNames)
            {
                Console.WriteLine($"Student {e:00}: {name}");
                e++;
            }
        }
    }
}
