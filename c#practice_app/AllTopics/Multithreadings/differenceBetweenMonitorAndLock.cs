using System;
using System.Reflection.Metadata;

namespace Amol
{
    public class DifferenceBetweenMonitorAndLock
    {
        static object _lock = new object();
        public static void AddOneMillion()
        {
            int Total = 0;
            for (int i = 1; i <= 1000000; i++)
            {
                lock (_lock)
                {
                    Total++;
                }
            }
        }

        //can be rewritten as shown below.
        static object _lock1 = new object();
        public static void AddOneAndOneMillion()
        {
            int Total = 0;
            for (int i = 1; i <= 1000000; i++)
            {
                // Acquires the exclusive lock
                Monitor.Enter(_lock1);
                try
                {
                    Total++;
                }
                finally
                {
                    // Releases the exclusive lock
                    Monitor.Exit(_lock1);
                }
            }
        }

        // In C# 4, it is implement slightly differently
        static object _lock2 = new object();
        public static void AddOneAndOnlyMillion()
        {
            int Total = 0;
            for (int i = 1; i <= 1000000; i++)
            {
                bool lockTaken = false;
                // Acquires the exclusive lock
                Monitor.Enter(_lock2, ref lockTaken);
                try
                {
                    Total++;
                }
                finally
                {
                    // Releases the exclusive lock
                    if (lockTaken)
                        Monitor.Exit(_lock2);

                }
            }
        }

    }
}

// So, in short, lock is a shortcut and it's the option for the basic usage.
// If you need more control to implement advanced multithreading solutions using TryEnter() Wait(), Pulse(), & PulseAll() methods,
// then the Montior class is your option
