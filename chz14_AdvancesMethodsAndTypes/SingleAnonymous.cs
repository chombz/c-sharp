using System;

namespace chz14_AdvancesMethodsAndTypes
{
    /// <summary>
    /// C# class that will be used to demonstrate assigning a single anonymous
    /// method to a delegate
    /// </summary>
    public class SingleAnonymous
    {
        //Delegate declaration inside the class
        delegate void Display(String message, int num);
        static void Main(string[] args)
        {
            //instantiate the diaplay delegate and assign it an anoyous online method
            Display display = delegate (string message, int num)
            {
                Console.WriteLine(message, num);
            };

            //invoke the display delegate message
            display("Missing you {0}", 5);
        }
    }
}
