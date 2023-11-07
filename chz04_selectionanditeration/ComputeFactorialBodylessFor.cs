using System;

namespace chz04_selectionanditeration
{
    /// <summary>
    /// C# that accepts a positive number from the user and computes its
    /// factorial Bodyless.
    /// </summary>
    class ComputeFactorialBodylessFor
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

            //Compute the factorial using a bodyless for loop
            for (; e < usernum; e++) 
            {
                factorial *= e;
            }
            //display the results
            Console.WriteLine($"The factorial of {usernum} is {factorial}.\n");
        }
    }
}
