using System;

namespace chz02_datatypes
{
    /// <summary>
    /// C# program to demonstrate to Greet User
    /// </summary>
    class GreetUser
    {
        //Main method begins with a program excution
        public static void Main(string[] args)
        {
            //Variable
            string username;

            //Ask for name
            Console.WriteLine("What\'s your name? ");
            //Connect username with Console.WriteLine
            username = Console.ReadLine();

            //Display username 
            Console.WriteLine($"Name of User is {username}");
            Console.WriteLine("This User name is {0}", username);
            Console.WriteLine("Hey " + username + " that\'s your name");

        }
    }
}
