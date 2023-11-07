using chz06_classesandmethods;
using System;


namespace chz06_classesandmethods
{
    /// <summary>
    /// C# program to demostrate working with the Rectangle class.
    /// </summary>
    public class DemoRect
    {
        //Main method begins with a program excution
        static void Main(string[] args)
        {
            //Declare and instantiate a rect object
            Rect r1 = new Rect();
            //Prompt the user the dimensions of r1
            Console.WriteLine(@"Please enter the rectangle's length in cm -> ");
            byte len = byte.Parse(Console.ReadLine());
            r1.setLength(len);
            Console.WriteLine(@"Please enter the rectangle's width in cm -> ");
            byte wid = byte.Parse(Console.ReadLine());
            r1.setWidth(byte.Parse(Console.ReadLine()));

            //Get dimensions of the second rectangle
            Console.WriteLine(@"Please enter the second rectangle's length in cm -> ");
            len = byte.Parse(Console.ReadLine());
            Console.WriteLine(@"Please enter the second rectangle's width in cm -> ");
            wid = byte.Parse(Console.ReadLine());

            //Declarr and instantiate the second rectangle with the user's measurements/dimensions
            Rect r2 = new Rect(len, wid);

            //Display the dimensions of r1 & r2
            r1.displayDimensions();
            r2.displayDimensions();
        }
    }
}

