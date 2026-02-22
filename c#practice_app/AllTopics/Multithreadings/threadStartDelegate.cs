using System;
using System.Threading;
using System.Threading.Tasks;
// In the example above to create a THREAD

namespace Amol
{
    public class ThreadStartDelegate
    {
        public static void RunThreadStartDelegate()
        {
            // we created an instance of Thread class and to it's constructor we have passed the name of the function that we want the thread to execute.
            Thread T1 = new Thread(Number.PrintNumbers); // Thread T1 = new Thread(Number.PrintNumbers);
            T1.Start();
            // We can rewrite the above line using ThreadStart delegate as shown below.
            // Thread T1 = new Thread(new ThreadStart(Number.PrintNumbers));

            // We can also rewrite the same line using delagate() keyword as shown below.
            // Thread T1 = new Thread(delegate () { Number.PrintNumbers(); });

            // We can also rewrite the same line using lambda expression as shown below.
            //  Thread T1 = new Thread(() => Number.PrintNumbers());

            //IMPORTANT 

            // Thread function need not be a static function always.
            // It can also be a non-static function.In case of non-static function we have to create an instance of the class.
            // As example   --   public  void PrintNumbers()
            // Called it by --   Number number = new Number(); 
            // Thread T1 = new Thread(number.PrintNumbers);
            // T1.Start();
        }
    }
    class Number
    {
        public static void PrintNumbers()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }

}

// Q1.Why a delegate need to be passed as a parameter to the Thread class constructor?
// Ans: The purpose of creating a Thread is to execute a function.
// A delegate is a type safe function pointer, meaning it points to a function that the thread has to execute.
// In short, all threads require an entry point to start execution.
// Any thread you create will need an explicitly defined entry point
// i.e a pointer to the function where they should begin execution.So threads always require a delegate.
