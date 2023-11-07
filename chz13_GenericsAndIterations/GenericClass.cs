using System;
using System.Collections;
using System.Collections.Generic;

namespace chz13_GenericsAndIterations
{
    /// <summary>
    /// Generic class that acceots a Tyoe parameter
    /// </summary>
    /// <typeparam name='T'>Type parameter passed to the Generic class</typeparam>>
    public class GenericClass<T> : IEnumerable<T>
    {
        T[] genericValues;//Declare a generic array

        public int Count { get; set; }
        public GenericClass(int userValue)
        {
            genericValues = new T[userValue];//Intantiate the generic array
            this.Count = 0;//Initialise the count property to zero
        }

        public void AddItems(T inputValue)
        {
            //Add items to the array if it's not already full
            if (this.Count < genericValues.Length)
            {
                genericValues[Count] = inputValue;
                this.Count++;
            }
            else
            {
                Console.WriteLine("Sorry the list is full.\nPlease restart the program and try again.");
            }
        }



        public void DisplayItems()
        {
            //Display the value or reference type of parameter<T>
            Console.WriteLine($"The <T> parameter is of type {typeof(T)}");
            //Console.WriteLine($"There are {Count} items in the list/collection.");
            //Output the items/values in the array
            Console.WriteLine($"The contents of the array are: ");
            foreach (T item in genericValues)
            {
                Console.WriteLine(item);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)genericValues).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return genericValues.GetEnumerator();
        }
    }
}
