using System;

namespace chz04_selectionanditeration
{
    class FirstTenIntsWhile
    {
        public static void Main(string[] args)
        {
            int e = 1;
            int c = 10;

            while (e < 10)
            {
                    Console.WriteLine($"{e}");
                e++;
            }
            Console.WriteLine($"{c}");
        }
    }
}
