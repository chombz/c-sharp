using System;

namespace chz02_datatypes

{
    /// <summary>
    /// C# program that demonstrates how to declare and use constants in your program.
    /// </summary>
    class CircArea
    {
        //Main method begins program execution
        static void Main(string[] args)
        {
            //Declare PI as a constant
            const float MYPI = 3.141592F;
            //Prompt the user for the radius of the circle
            Console.WriteLine("Please enter the radius of the circle in cm -> ");
            uint radius = uint.Parse(Console.ReadLine());
            //Calculate the area and circumference of the circle
            //float area = MYPI * radius * radius; //old school way
            float area = (float)(MYPI * Math.Pow(radius, 2));
            float circumference = (float)(MYPI * (radius * 2));
            //display the results
            Console.WriteLine($"The area of the circle is {area: 0.0000} cm2.");//3 decimal places
            Console.WriteLine($"The circumference of the cirecle is {circumference:0.##}cm.");//2 d.p
        }
    }
}
