using System;

namespace chz03_statementsOperators
{
    /// <summary>
    /// C# program to demonstrate how Comparison operators work in C#. 
    /// </summary>
    class ComparisionOperators
    {
        public static void Main(String[] args)
        {
            //Variables to be used in the program
            int firstNum = 5;
            int secondNum = 8;
            int thirdNum = firstNum;

            //compare the above 3 numbers and display them 
            Console.WriteLine("Number comparision between 5, 8 and 5");
            Console.WriteLine($"{firstNum} > {secondNum} is {thirdNum}", firstNum, secondNum, (firstNum > secondNum));
            Console.WriteLine($"{firstNum} < {secondNum} is {thirdNum}", firstNum, secondNum, (firstNum < secondNum));
            Console.WriteLine($"{firstNum} >= {secondNum} is {thirdNum}", firstNum, secondNum, (firstNum >= secondNum));
            Console.WriteLine($"{firstNum} <= {secondNum} is {thirdNum}", firstNum, secondNum, (firstNum <= secondNum));
            Console.WriteLine($"{firstNum} == {secondNum} is {thirdNum}", firstNum, secondNum, (firstNum == secondNum));
            Console.WriteLine($"{firstNum} != {secondNum} is {thirdNum}", firstNum, secondNum, (firstNum != secondNum));

        }
    }
}
