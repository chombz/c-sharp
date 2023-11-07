using System;

namespace chz07_inheritanceandpolymorphism
{
    /// <summary>
    /// C# program that demonstrates the concept of inheriting from abstract classes
    /// and creating an instance of the Bat class
    /// </summary
    public class DemoDolphin : Dolphin
    {
        //Main method begins program execution
        static void Main(string[] args)
        {
           //Declare and instantiate a Dolphin object
           DemoDolphin pomboo = new DemoDolphin();

           //Set the field values dervired form the Animal and Mammal abstract class
           pomboo.food = "fish";//Derived from the Animal class
           pomboo.activity = "Dolphins are nice animals";//Derived from the Animal class
           pomboo.habitat = "The ocean is thier habitat";

           //Display the behaviour of the DemoDophin instance
           pomboo.DisplayDophinBehaviour();
         }


        private void DisplayDetails()
        {
            Console.WriteLine($"\nDetails of the Dolphin" +
                              $"\n-------------------------");
            Console.WriteLine($"\nDiet: "); this.Eat(food);
            Console.WriteLine($"\nNumber of Flippers: {FLIPPERS}" +
                              $"\nNumber of Snout: {SNOUT}" +
                              $"\nHabitat: {this.habitat}" +
                              $"\nBehaviour: {this.activity}");
            Console.WriteLine("\nReproduction: ");
            MultiplyMammal("\nDolphin");
            Console.WriteLine($"\n-------------------------");
        }
    }
}
