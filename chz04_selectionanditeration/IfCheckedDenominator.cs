using System;

namespace chz04_selectionanditeration
{
    /// <summary>
    /// C#program that demonstrates use of the if construct to prevent interger
    /// division by zero.
    /// </summary>
    public class IfCheckedDenominator
    {
        //Main method begins prgrom execution
        static void Main(string[] args)
        {
            //varibles
            uint numerator;
            uint denominator;
            uint quotient;

            //prompt the user for a numerator
            Console.WriteLine($"Please enter a denominator to be used in division -> ");
            numerator = uint.Parse(Console.ReadLine());

            UserPrompt: //Label that will be used on a goto statement
            //prompt the user for a denominator
            Console.WriteLine($"Please enter a denominator to be used in division -> ");
            denominator = Convert.ToUInt32(Console.ReadLine());


            //Check wheaather the user has entered 0 as the denominator and prompt them 
            //for a different number
            if (denominator == 0)
            {
                Console.WriteLine($"Please enter a non-zero \'0\' number as " +
                                  $" division by zero will cause errors!!");
                goto UserPrompt;
            }

            quotient = numerator / denominator;

            //display the result
            Console.WriteLine($"{numerator} {'\u00f7'} {denominator} = {quotient}");
        }
    }
}
