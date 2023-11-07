using System;

namespace chz10_namespaces
{
    /// <summary>
    /// Enumerations of the various seasons in the year.
    /// </summary>
    public enum Seasons
    {
        //Seasons of the year
        Summer,
        Autumn,
        Winter,
        Spring
    }

    public class DemoSeason
    {
        static void Main(string[] args)
        {
            var favouriteTime = Seasons.Summer;
            var plantingTime = Seasons.Spring;

            //Display the various times
            Console.WriteLine("The time to till the land is {0}" +
                              "\nTime to party is {1}", plantingTime, favouriteTime);
        }
    }
}
