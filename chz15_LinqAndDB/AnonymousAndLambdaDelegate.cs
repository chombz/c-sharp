using System;


namespace chz15_LinqAndDB
{
    /// <summary>
    /// C# program to demonstrate using a delegate anonymously and with a lambda expression.
    /// </summary>

    //Delegate declaration outside the class
    public delegate string MethodDelegate(int num1, int num2);
    public class AnonymousAndLambdaDelegate
    {
        static void Main(string[] args)
        {
            //Assign the delegate a static anonymous method
            MethodDelegate md = delegate (int arg1, int arg2)
            {
                return (arg1 + arg2).ToString();
            };
            Console.WriteLine("The sum of {0} and {1} is {2}", 10, 20, md(10, 20));
            MethodDelegate lambdaDel = (int num1, int num2) => (num1 + num2).ToString();
            Console.WriteLine($"Sum of 7 and 5 is {lambdaDel(7, 5)}");
        }    
    }
}
