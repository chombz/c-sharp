using System;

namespace chz05_arrays
{
    /// <summary>
    /// C# program to demonstrate how to create and display contents of a jagged array
    /// </summary>
    public class JaggedArray
    {
        //Main method
        static void Main(string[] args)
        {
            string[][] companies = new string[5][];
            companies[0] = new string[] { "Intel, AMD, SnapDragon" };//proccesors
            companies[1] = new string[] { "Toyota, Nissan, Suzuki" };//car brands
            companies[2] = new string[] { "Samsung, Apple, Google" };//mobile chips
            companies[3] = new string[] { "NVIDIA, AMD" };//Graphics Cards
            companies[4] = new string[] { "Micheal, Edwin, Isaac" };//classmates


            //Display the contents using jagged array
            for (int e = 0; e <= companies.GetUpperBound(0); e++)
            {
                int c = 0;
                Console.WriteLine($"List of Companies in group {(e + 1)} : ");
                do
                {
                    Console.Write($"{companies[e][c]} ");
                    c++;
                } while (c < companies[e].GetLength(0));
                Console.WriteLine();
            }
        }
    }
}
