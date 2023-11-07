using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chz04_selectionanditeration
{
    /// <summary>
    /// C# progam do display a star pattern using nested loops
    /// </summary>
    class StarPatternNestedLoops
    {
        static void Main(string[] args)
        {
            //variables
            int e = 0;
            int c = 0;

            for (; e < 5; e++)
            {
                for (; c <= e; c++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }
        }
    }
}
