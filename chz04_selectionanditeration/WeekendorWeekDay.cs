using System;

namespace chz04_selectionanditeration
{
    /// <summary>
    /// C# program that uses the "switch...case" decision construct to inform the user wheather
    /// the day of the week they entered is a day of the week or weekend
    /// </summary>
    class WeekendorWeekDay
    {
        //Main mthod begins program excution
        static void Main(string[] args)
        {
            Console.WriteLine(@"Please enter a day of the week and I'll tell you if it's a " +
                              "day of the week or   weekend -> ");
            string day = Console.ReadLine().ToLower();

            //Use the switch....case to determine when the day occurs
            switch (day)
            {
                case "monday":
                case "tueday":
                case "wednesday":
                case "thursday":
                case "friday":
                    Console.WriteLine($"{day} is a weekday.");
                    break;
                case "saturday":
                case "sunday":
                    Console.WriteLine($"{day} is on the weekend.");
                    break;
                default:
                    Console.WriteLine($"{day} is an invalid day! Please try with values Sunday - Monday.");
                    break;
            }
        }
    }
}
