using System;
using System.Collections;

namespace chz12_DelegatesEventAndCollections
{
    /// <summary>
    /// C# program to demonstrate the array list class, some of
    /// its methods and properties
    /// </summary>
    public class ArrayListDemo
    {
        //Main method begins program execution
        static void Main(string[] args)
        {
            ArrayList fruitList = new ArrayList();
            //Display the initial capacity of the arraylist
            Console.WriteLine($"The fruitList initial capacity is {fruitList.Capacity}");
            fruitList.Add("Strawberry");
            fruitList.Add("Leeches");
            fruitList.Add("Mango");
            fruitList.Add("Banana");
            fruitList.Add("Blueberries");
            fruitList.Add("Avocado");
            //Display the original fruitlist
            Console.WriteLine($"The original fruitList has {fruitList.Count} fruits, and they are given below");
            foreach (var fruit in fruitList)
            {
                Console.WriteLine(fruit);
            }



            //Insert a fruit before mango
            fruitList.Insert(2, "Kiwi Fruit");
            //Replace the Avocado with Dragon fruit
            fruitList[6] = "Dragon Fruit";



            //Display the modified fruitlist
            Console.WriteLine($"The unsorted modified fruitList has {fruitList.Count} fruits, and they are given below");
            for (int n = 0; n < fruitList.Count; n++)
            {
                Console.WriteLine(fruitList[n]);
            }



            //Display the modified fruitlist in descending order
            fruitList.Sort();
            fruitList.Reverse();
            Console.WriteLine("\nThe list of fruits in descending order: ");
            for (int n = 0; n < fruitList.Count; n++)
            {
                Console.WriteLine($"{(n + 1)}. {fruitList[n]}");
            }
        }
    }
}
