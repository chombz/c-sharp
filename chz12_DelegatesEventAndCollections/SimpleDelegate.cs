using System;

namespace chz12_DelegatesEventAndCollections
{
    /// <summary>
    /// C# program to demonstrate how single method delegates work
    /// </summary>

    //Declare the delagate outside the class
    public delegate int Calculation(int num1, int num2);
    
    public class SimpleDelegate
    {
        static int Addnums(int num1, int num2)
        { return num1 + num2; }


        static int MultiplyNums(int num1, int num2)
        { return num1 * num2; }

        static int SubtractNums(int num1, int num2)
        { return num1 > num2 ? num1 - num2 : num2 - num1; }

        //main method begins with program execution
        public static void Main(string[] args)
        {
            int valueOne = 5;
            int valueTwo = 32;

            //Declare delgation
            Calculation addDelgate, subDelegate, prodDelegate;

            //instantiate the simple delegates
            addDelgate = new Calculation(Addnums);
            prodDelegate = new Calculation(MultiplyNums);
            subDelegate = new Calculation(SubtractNums);

            //Call in the methods
            Console.WriteLine($"The sum of {valueOne} + {valueTwo} = {addDelgate(valueOne, valueTwo)}");
            Console.WriteLine($"The product of {valueOne} x {valueTwo} = {prodDelegate(valueOne, valueTwo)}");
            Console.WriteLine($"The difference of {valueOne} - {valueTwo} = {subDelegate(valueOne, valueTwo)}");

        }
    }
}
