using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chz03_statementsOperators
{
    /// <summary>
    /// C# program demonstrating Checked Overflow
    /// </summary>
    public class CheckedOverflow
    {
        public static void Main()
        {
            byte numOne = 255;
            byte numTwo = 1;
            byte result = 0;
            try
            {
                checked
                {
                    result = (byte)(numOne + numTwo);
                }
                Console.WriteLine("Result: " + result);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
