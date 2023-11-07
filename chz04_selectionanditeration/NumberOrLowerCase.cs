using System;

namespace chz04_selectionanditeration
{
    /// <summary>
    /// C# program that accepts a character from the user and determines if it's a number
    /// between 0-9 or a lowercase letter
    /// </summary>
    public class NumberOrLowerCase
    {
        //main method begins with a program excution
        static void Main(string[] args)
        {
            //Promoting the user for a character
            Console.WriteLine(@"Please enter a single character and I will tell " +
                              "you if its a number or lowercase letter");
            char userChar = Console.ReadLine()[0];//fetch only the first character from the input string;

            //Check what was entered by the user and give back an apt message
            if (userChar >= '0' && userChar <= '9')
                Console.WriteLine($"{userChar} is a number.");
            else if (userChar >= 'a' && userChar <= 'z')
                Console.WriteLine($"{userChar} is a lower case letter.");
            else
                Console.WriteLine($"{userChar} is either a number or a lowercase letter");
        }
    }
}
