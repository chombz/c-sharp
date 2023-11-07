using System;
using System.Collections;
using chz09_properties_and_indexes;

namespace chz12_DelegatesEventAndCollections
{
    /// <summary>
    /// C# class to demonastrate the Hashtable class and some of its methods.
    /// </summary>
    class HashTableDemo
    {
        static void Main(string[] args)
        {
            uint n = 1;
            Hashtable bookTable = new Hashtable();
            bookTable.Add(101, new Book(578, "C# How to Program", "Deitel & Deitel", 54.55f));
            bookTable.Add(102, new Book(579, "C# Notes for Professionals", "Et al", 0.0f));
            bookTable.Add(103, new Book(580, "Java The Complete Reference", "Oracle Inc.", 89.99f));
            bookTable.Add(106, new Book(581, "Python Programming", "Python Author", 25.59f));



            //Display the number of books in the books hashtable
            Console.WriteLine($"The number of books in the books Hashtable is : {bookTable.Count}\n");



            //Get a collection of the keys in the books hashtable
            ICollection bookTableKeys = bookTable.Keys;
            //Display the keys
            Console.WriteLine("The keys in the books hashtable are: \n------------------------------------");
            foreach (var key in bookTableKeys)
            {
                Console.WriteLine($"Key {n:00} -> {key}");
                n++;
            }



            //Display the keys and their corresponding values
            Console.WriteLine("Keys and values in the hashtable are: ");
            DisplayHashTableContents(bookTable);

            Console.WriteLine("Remove the details for the key number 106");
            if (bookTable.ContainsKey(106))
            {
                bookTable.Remove(106);
                Console.WriteLine("Remove the details for record 106");
            }
            Console.WriteLine("The contents of the books hashtable after removing key 106 are: \n");
            DisplayHashTableContents(bookTable);
            Console.WriteLine($"The books hashtable is read-only");
        }

        private static void DisplayHashTableContents(Hashtable bookTable)
        {
            IDictionaryEnumerator bookEnumerator = bookTable.GetEnumerator();
            while (bookEnumerator.MoveNext())
            {
                Console.WriteLine($"Key: {bookEnumerator.Key}" +
                                  $"\nValue: {bookEnumerator.Value.ToString()}");
            }
        }
    }
}
