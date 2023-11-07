using System;

namespace chz07_inheritanceandpolymorphism
{
    /// <summary>
    /// Class that inherits from the Mammal class and will be used to create
    /// Bat objects
    /// </summary>
    public class Bat : Mammal
    {
        //Declare instance constant Fields
        public const byte WINGS = 2;
        public const byte LEGS = 2;
        public const byte EARS = 2;
        public override void Eat(string diet)
        {
            Console.Write($"The Bats eats: {diet}");
        }

        public void DisplayBatBehaviour()
        {
            Console.WriteLine($"\nThe Bat flies.");
        }
    }
}
