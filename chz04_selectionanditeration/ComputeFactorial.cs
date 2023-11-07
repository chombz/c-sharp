using System;

namespace chz04_selectionanditeration
{
    /// <summary>
    /// C# that accepts a positive number from the user and computes its
    /// factorial.
    /// </summary>
    public class ComputeFactorial
    {
        static void Main(string[] args)
        {
            //variables
            int e = 1;//looping variable
            int usernum = -1;
            long factorial = 1L;

            //use a loop to prevent the user from giving a number
            while (usernum < 0)
            {
                Console.WriteLine("Please enter a positive number and I\'ll tell you" +
                                  " its factorial -> ");
                usernum = int.Parse(Console.ReadLine());
            }

            if (usernum == 0 || usernum == 1)
            {
                factorial = 1L;
            }
            else
            {
                for (e = 2; e <= usernum; e++)
                {
                    factorial *= e;
                }
            }

            //display the results
            Console.WriteLine($"The factorial of {usernum} is {factorial}.\n");
        }
    }
}
