using System;

namespace chz03_statementsOperators
{
    class ArthmeticsOperators
    {
        /// <summary>
        /// C# program to demonstrate how arithmetic operators work in C#. 
        /// </summary>
        public static void Main(string[] args)
        {
            //variables to be used in the program
            byte firstNum = 8;
            byte secondNum = 25;
            int product, sum, quotient, difference, remainder;
            product = secondNum * firstNum;
            sum = secondNum + firstNum;
            quotient = secondNum / firstNum;
            difference = secondNum - firstNum;
            remainder = secondNum % firstNum;
            char divideSymbol = '\u00f7';

            //Display the results
            Console.WriteLine($" {secondNum} x {firstNum} = {product}");
            Console.WriteLine($" {secondNum} + {firstNum} = {sum}");
            Console.WriteLine($" {secondNum} {divideSymbol} {firstNum} = {quotient}");
            Console.WriteLine($" {secondNum} - {firstNum} = {difference}");
            Console.WriteLine($" {secondNum} % {firstNum} = {remainder}");


            int postfix = secondNum++;
            int prefix = --firstNum;

            Console.WriteLine("After postfixing the secondNum variable we get " + postfix + "\n");
            Console.WriteLine("After prefixing the firstNum variable we get " + prefix + "\n");
            Console.WriteLine("Value of the secondNum variable after postfixing is " + secondNum + "\n");
            Console.WriteLine("Value of the firstNum variable after prefixing is " + firstNum + "\n");
        }
    }
}
