using System;

namespace chz07_inheritanceandpolymorphism
{
    /// <summary>
    /// Class that inherits from the Mammal class and will be used to create
    /// Dolphin objects
    /// </summary>
    public class Dolphin : Mammal
    {
        //Declare instance constant Fields
        public const byte FLIPPERS = 2;
        public const byte SNOUT = 1;
        public const byte BLOWHOLE = 1;
        public override void Eat(string diet)
        {
            Console.WriteLine($"The dolphin eats: {diet}");
        }

        public void DisplayDophinBehaviour()
        {
            Console.WriteLine($"The dolphin swims.");
        }
    }
}
