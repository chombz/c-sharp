using System;

namespace chz07_inheritanceandpolymorphism
{
    /// <summary>
    /// C# program that demonstrates the concept of inheriting from abstract classes
    /// and creating an instance of the Bat class
    /// </summary>
    public class DemoBat : Bat
    {
        //Main method begins program execution
        static void Main(string[] args)
        {
            //Declare and instantiate a Bat object
            DemoBat batman = new DemoBat();

            //Set the field values dervired form the Animal and Mammal abstract class
            batman.food = "Insects";//Derived from the Animal class
            batman.activity = "Bats are nocturnal";//Derived from the Animal class
            batman.habitat = "Batcave is underneath Wayne Manor.";

            //Display the behaviour of the DemoBat instance
            batman.DisplayBatBehaviour();
        }


        private void DisplayDetails()
        {
            Console.WriteLine($"\nDetails of the Bat" +
                              $"\n-------------------------");
            Console.WriteLine($"\nDiet: "); this.Eat(food);
            Console.WriteLine($"\nNumber of Wings: {WINGS}" +
                              $"\nNumber of Legs: {LEGS}" +
                              $"\nHabitat: {this.habitat}" +
                              $"\nBehaviour: {this.activity}");
            Console.WriteLine("\nReproduction: ");
            MultiplyMammal("\nBat");
            Console.WriteLine($"\n-------------------------");
        }
    }
}
