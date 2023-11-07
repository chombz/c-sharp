using System;
using System.Threading;

namespace chz15_LinqAndDB
{
    /// <summary>
    /// C# program demonstrating how to work with synchronised threads
    /// </summary>
    class ThreadDemo
    {
        //Class/static variables to control the threads
        private static string threadOutput = "";
        private static bool stopThreads = false;

        //Main method begins program execution
        static void Main(string[] args)
        {
            Console.WriteLine("Main thread started!");

            //Start other threads
            Thread thread1 = new Thread(new ThreadDemo().DisplayThread1);
            Thread thread2 = new Thread(new ThreadDemo().DisplayThread2);


            //Assign the above threads names
            thread1.Name = "Thread1";
            thread2.Name = "Thread2";

            //Run/execute the threads
            thread1.Start();
            thread2.Start();
            //Join the threads to the main thread to make it wait for them to finish processing then it can resume
            thread1.Join();
            thread2.Join();

            Console.WriteLine("Main thread ended");
        }

        private void DisplayThread1()
        {
            while (stopThreads == false)
            {
                // lock on the current instance of the class for thread #1  
                lock (this)
                {
                    Console.WriteLine("Display Thread 1");
                    threadOutput = "Hello from Thread1";
                    Thread.Sleep(150);  // simulate a lot of processing  
                                        // tell the user what thread we are in thread #1  
                    Console.WriteLine("Thread 1 Output --> {0}", threadOutput);
                }// lock released  for thread #1 here  
            }
        }
        private void DisplayThread2()
        {
            while (stopThreads == false)
            {
                // lock on the current instance of the class for thread #2  
                lock (this)
                {
                    for (int e = 1; e <= 10; e++)
                    {
                        Console.WriteLine("Display Thread 2");
                        threadOutput = "Hello from Thread2";
                        Thread.Sleep(100);  // simulate a lot of processing  
                                            // tell the user that thread we are in thread #2  
                        Console.WriteLine("Thread 2 Output --> {0}", threadOutput);
                    }
                    stopThreads = true;//Stop the loops
                } // lock released  for thread #2 here  
            }
        }
    }
}
