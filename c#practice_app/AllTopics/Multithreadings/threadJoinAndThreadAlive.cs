using System;
using System.Threading;
using System.Threading.Tasks;
// Thread.Join and Thread.IsAlive functions with an example. 

// 1) Thread.Join 
// Join blocks the current thread and makes it wait until the thread on which Join method is invoked completes.
// Join method also has a overload where we can specify the timeout.
// If we don't specify the timeout the calling thread waits indefinitely, until the thread on which Join() is invoked completes.
// This overloaded Join(int millisecondsTimeout) method returns boolean.
// True if the thread has terminated otherwise false. Join is particularly useful when we need to wait and collect result from a thread execution
// or if we need to do some cleanup after the thread has completed.

//2) Thread.IsAlive
// IsAlive returns boolean. True if the thread is still executing otherwise false.

namespace Amol
{
    public class ThreadJoinAndThreadAlive
    {
        public static void RunThreadJoinAndThreadAlive()
        {
            Console.WriteLine("Main Started");

            // below T1 and T2 will not execute in partiular sequence. so if we want to print in particular order then we use join thread.
            Thread T1 = new Thread(ThreadJoinAndThreadAlive.Thread1Function);
            T1.Start();

            Thread T2 = new Thread(ThreadJoinAndThreadAlive.Thread2Function);
            T2.Start();

            if (T1.Join(1000))   // here we go for join
            {
                Console.WriteLine("Thread1Function completed");
            }
            else
            {
                Console.WriteLine("Thread1Function hot not completed in 1 second");
            }

            T2.Join();
            Console.WriteLine("Thread2Function completed");

            for (int i = 1; i <= 10; i++)
            {
                if (T1.IsAlive)
                {
                    Console.WriteLine("Thread1Function is still doing it's work");
                    Thread.Sleep(500);
                }
                else
                {
                    Console.WriteLine("Thread1Function Completed");
                    break;
                }
            }

            Console.WriteLine("Main Completed");

        }

        public static void Thread1Function()
        {
            Console.WriteLine("Thread1Function started");
            Thread.Sleep(5000);
            Console.WriteLine("Thread1Function is about to return");
        }

        public static void Thread2Function()
        {
            Console.WriteLine("Thread2Function started");
        }

    }
}
