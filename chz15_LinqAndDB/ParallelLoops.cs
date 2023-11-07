using System;
using System.Threading;
using System.Threading.Tasks;

namespace chz15_LinqAndDB
{
    /// <summary>
    /// C# program to demonstrate working with parallel loop
    /// </summary>
    class ParallelLoops
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Displaying the first ten numbers using a normal for loop -> " +
                "\n----------------------------------------------");
            for (int e = 1; e <= 10; e++)
            {
                Console.WriteLine($"{e:00} executed by thead with id {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(100);//Sleep for 100 milliseconds
            }
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Displaying the first ten numbers using a parallel for loop -> " +
                "\n----------------------------------------------");
            Parallel.For(1, 10, e =>
            {
                Console.WriteLine($"{e:00} executed by thead with id {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(100);//Sleep for 100 milliseconds
            });
            Console.WriteLine("----------------------------------------------");
        }
    }
}
