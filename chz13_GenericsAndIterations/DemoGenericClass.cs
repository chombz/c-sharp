using System;

namespace chz13_GenericsAndIterations
{
    /// <summary>
    /// C# program to demonstrate how to work with generic classes
    /// </summary>
    public class DemoGenericClass
    {
        static void Main(string[] args)
        {
            int e;

            //Declare value and reference types of the Generic class
            GenericClass<float> temps;
            GenericClass<Person> people;

            int numOfItems;

            // Prompt the user for the number of temperatures they wish to store
 
            Console.WriteLine($"How many temperatures do you wish to store?");
            numOfItems = int.Parse(Console.ReadLine());
            //Instantiate the generic array of temps.
            temps = new GenericClass<float>(numOfItems);
            //Read in the temps. from the user
            for (e = 0; e < numOfItems; e++)
            {
                Console.WriteLine($"Please enter the value for temperature {e + 1} -> ");
                temps.AddItems(float.Parse(Console.ReadLine()));
            }

             //Prompt the user for the number of Persons, their details and finally display them
             Console.WriteLine($"How many number of people do you wish to store?");
                                numOfItems = int.Parse(Console.ReadLine());
             //instantiate the generic array of persons/people
             people = new GenericClass<Person>(numOfItems);
             //read in the names of the persons from the user
             for (e = 0; e < numOfItems; e++)
             {
                Console.WriteLine($"Please enter the name of the person {e + 1} ->");
                string name = Console.ReadLine();
                Console.WriteLine($"Please enter {name}\'s DOB -> ");
                DateTime dob = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine($"Please enter {name}\'s gender -> ");
                char gender = char.Parse(Console.ReadLine());
                Console.WriteLine($"Please enter {name}\'s nationality -> ");
                string nationality = Console.ReadLine();
                
                people.AddItems(
                                new Person(name, dob, gender, nationality)
                               );
             }
             //display the details for each person
             foreach (Person person in people)
             {
                Console.WriteLine(person.ToString());
             }


       }
    }
}
