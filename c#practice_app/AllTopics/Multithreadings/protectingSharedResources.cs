using System;
using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
// Questions
// 1.What happens if shared resources are not protected from concurrent access in multithreaded program
// Ans-- The output or behaviour of the program can become inconsisten
// 2. How to protect shared resources from concurrent access

namespace Amol
{
    /*
     
        public class ProtectingSharedResources
          {
             static int Total = 0;
             public static void RUnProtectingSharedResources() {

                 AddOneMillion();
                 AddOneMillion();
                 AddOneMillion();
                 Console.WriteLine("Total = " + Total);
             }
             public static void AddOneMillion()
             {
                 for (int i = 1; i <= 1000000; i++)
                 {
                     Total++;
                 }
             }
             // The above program is a single-threaded program.In the Main() method,
             // AddOneMillion() method is called 3 times, and it updates the Total field correctly as expected,
             // and finally prints the correct total i.e 3000000.
         }

    */

    public class ProtectingSharedResources
    {
        static int Total = 0;
        public static void RUnProtectingSharedResources()
        {
            Thread thread1 = new Thread(ProtectingSharedResources.AddOneMillion);
            Thread thread2 = new Thread(ProtectingSharedResources.AddOneMillion);
            Thread thread3 = new Thread(ProtectingSharedResources.AddOneMillion);

            thread1.Start();
            thread2.Start();
            thread3.Start();

            thread1.Join();
            thread2.Join();
            thread3.Join();

            Console.WriteLine("Total = " + Total);

        }
        public static void AddOneMillion()
        {
            for (int i = 1; i <= 1000000; i++)
            {
                Total++;
            }
        }
        // Every time we run the above program, we get a different output.
        // The inconsistent output is because the Total field
        // which is a shared resource is not protected from concurrent access by multiple threads.
        // The operator ++ is not thread safe.There are several ways to fix this. Let's explore 2 of the options.

        // Using Interlocked.Increment() method: Modify AddOneMillion() method as shown below.
        // The Interlocked.Increment() Method, increments a specified variable and stores the result, as an atomic operation


        // below function will give always same result..
        public static void AddOnlyOneMillion()  // use this method instead of above AddOneMillion Method -- line no 60
        {
            for (int i = 1; i <= 1000000; i++)
            {
                Interlocked.Increment(ref Total);
            }
        }

        //The other option is to use a lock.

        static object _lock = new object();

        public static void AddOneAndOnlyMillion()   // use this method instead of above AddOneMillion Method -- line no 60
        {
            for (int i = 1; i <= 1000000; i++)
            {
                lock (_lock)
                {
                    Total++;
                }
            }
        }
    }

  //Q1. Which option is better?
    // From a performance perspective using Interlocked class is better over using locking.
    // Locking locks out all the other threads except a single thread to read and increment the Total variable.
    // This will ensure that the Total variable is updated safely.
    // The downside is that since all the other threads are locked out, there is a performance hit.
    // The Interlocked class can be used with addition/subtraction(increment, decrement, add, etc.)
    // on and int or long field.The Interlocked class has methods for incrementing, decrementing, adding, and reading variables atomically.
}
