using System;

namespace chz12_DelegatesEventAndCollections
{
    /// <summary>
    /// C# program to demonstrate how single method Multi-cast Delegates work
    /// </summary>
    /// 

    //Declare the Multi-cast DelegatesS outside the class
    public delegate void MultiCalcS(int num1, int num2);


    public class MulticastDelegate
    {
        static void AddNums(int num1, int num2)
        {
            Console.WriteLine($"{num1} + {num2} = {(num1 + num2)}");
        }

        static void MultiplyNums(int num1, int num2)
        {
            //Console.WriteLine($"{num1} x {num2} is {(num1 * num2)}");
            Console.WriteLine("{0} x {1} = {2}",num1,num2,(num1 * num2));
        }

        static void SubtractNums(int num1, int num2)
        {
            Console.WriteLine($"{num1} - {num2} = {(num1 > num2 ? num1 - num2 : num2 - num1)}");
        }

        static void DivideNums(int num1, int num2)//In real life throw and handle relevant
        {
            Console.WriteLine($"{num1} {'\u00f7'} {num2} = {(num1 / num2)}");
        }

        static void GetRemainder(int num1, int num2)
        {
            Console.WriteLine($"{num1} % {num2} = {(num1 % num2)}");
        }




        //main method begins with program execution
        static void Main(string[] args)
        {
            //Declare and instantiate the multicast delegate
            MultiCalcS mathOperation = new MultiCalcS(AddNums);

            //Add other class methods to the multicast delegate
            mathOperation += MultiplyNums;
            mathOperation += SubtractNums;
            mathOperation += DivideNums;
            mathOperation += GetRemainder;

            //Prompt the user for the numbers to be used in the calculation
            Console.WriteLine("Please enter the first number to be used in the calculation -> ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the first number to be used in the calculation -> ");
            int num2 = int.Parse(Console.ReadLine());

            //perform and display the result of each arithmetic operation
            mathOperation(num1, num2);

            //Remove the addition and division methods
            Console.WriteLine("Removing the addition and division methods....\n");
            mathOperation -= AddNums;
            mathOperation -= DivideNums;

            Console.WriteLine("Remaining operators are addition and substraction");
            //perform and display the result of each arithmetic operation
            mathOperation(num1, num2);
        }
    }
}
