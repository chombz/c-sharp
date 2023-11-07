using System;

namespace chz05_arrays
{
    /// <summary>
    /// C# prgram to demonstrate how to create a rectangular 2-D array
    /// </summary>
    public class Rectangular2DArray
    {
        public static void Main(string[] args)
        {
            int[,] dimension = new int[4, 5];
            int numOne = 1;//used for display purpose
            for (int e = 0; e < 4; e++)
            {
                for (int c = 0; c < 5; c++)
                {
                    //populate the array elements with values
                    dimension[e, c] = numOne;
                    numOne++;
                }
            }

            //Display the values in the 2-D array above
            for (int e = 0; e < dimension.GetLength(0); e++)//get the length of the rows
            { 
                for (int c = 0; c < dimension.GetLength(1); c++)//get the length of the columns
                {
                    Console.Write($"{dimension[e,c]:00}");
                }
                Console.WriteLine();
            } 
        }
           
    }
}
