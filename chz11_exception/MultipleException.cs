using System;

namespace chz11_exception
{
    /// <summary>
    /// c# program to demonstrate how to create multiple Exceptions.
    /// </summary>
    public class MultipleExceptions
    {
        //Main method begins program execution 

        static void Main(string[] args)
        {
            byte numerator, denominator, quotient;
            try
            {
                //prompt the user for the numerator and denominator

                Console.WriteLine($"Please enter the numerator ->");
                numerator = byte.Parse(Console.ReadLine());

                Console.WriteLine($"Please enter the numerator ->");
                denominator = byte.Parse(Console.ReadLine());

                //Throw an exception when the user enters 0 for the denominator
                if (denominator == 0)
                {
                    throw new DivideByZeroException($"Zero entered as a denominator," +
                        $"which will cause division errors.\nPlease enter a non-zero valuelike 8 or 5\n");
                }
                //Divide when the user gives us the correct inputs
                quotient = (byte)(numerator / denominator);

                //Display the results
                Console.WriteLine($"{numerator} {'\u00f7'} {denominator}");
            }
            catch (FormatException)
            {
                Console.WriteLine($"you have entered a string that cannot be converted" +
                    $" to a number.\nplease use digit like 3 or 4\n");
            }
            catch (OverflowException)
            {
                Console.WriteLine($"you have entered a number less than zero \'0\' " +
                   $" or greater than 255.\n please enter values between 1-255.\n");
            }
            catch (DivideByZeroException dbze)
            {
                Console.WriteLine(dbze.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"The exception" +
                    $"{ex.GetType().ToString().Replace("System.", "")}" +
                    $"occured!");
            }

        }
    }
}

