using System;

namespace chz14_AdvancesMethodsAndTypes
{
    //Delegate declaration
    delegate void Display();

    /// <summary>
    /// C# program demonstrating how to work with multiple anonymous methods using 
    /// delegates.
    /// </summary>
    class MultiAnonymous
    {

        static void Main(string[] args)
        {

            //Delegate instantiated with a single anonymous method
            Display disp = delegate ()
            {
                Console.WriteLine($"Insert the first anonymous method!!");
            };


            //Add a second anonymous method to the delegate
            disp += delegate ()
            {
                Console.WriteLine($"Insert the second anonymous method!!");
            };

            //Prompt the user for their name
            Console.WriteLine("Please enter your name -> ");
            string username = Console.ReadLine();

            //Add the 3rd anonymous method to the delegate
            disp += delegate ()
            {
                Console.WriteLine($"Hello {username} from the 3rd anonymous method.");
            };

            //Invoke/call the delegate
            disp();
        }
           
    }
}
