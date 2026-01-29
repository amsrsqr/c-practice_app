using System;
using System.Collections.Generic;
// A multicast delegate is a delegate that can hold references to more than one method.
// When the delegate is invoked, it calls all the methods in its invocation list in order.
// Decalred delegates return type should be match when you access it in multicast delegate. for ex. void , int, string etc.

public delegate void SimpleDelegate();
class MultiCastDelegate {

    public static void RunMultiCaseDelegates() {

        //SimpleDelegate SD = new SimpleDelegate(SimpleMethod1);   // This is simple regular delegate to call a method
        //SD();

        // This is multicase delegate means we can call multiple function using different reference of SimpleDelegate

        SimpleDelegate sd1, sd2, sd3, sd4;
        sd1 = new SimpleDelegate(SimpleMethod1); //1 
        sd2 = new SimpleDelegate(SimpleMethod2);  //2
        sd3 = new SimpleDelegate(SimpleMethod3); //3
        // This sd4 can have access of all three methods
        // So this is called multicast delegate
        sd4 = sd1 + sd2 + sd3;
        //sd4 = sd1 + sd2 + sd3 - sd4; // You can also remove a method from multicast delegate using '-'
        sd4(); // This will call all three methods one by one

        /* You can call delegates as below as well using '+' & instance.
         SimpleDelegate sd = new SimpleDelegate(SimpleMethod1);
          sd += SimpleMethod2;
          sd += SimpleMethod3;
          sd -= SimpleMethod2; // This will remove SimpleMethod2 from the invocation list
          sd()
         */
    }

    public static void SimpleMethod1() {

        Console.WriteLine("SimpleMethod1");
    }
    public static void SimpleMethod2()
    {

        Console.WriteLine("SimpleMethod2");
    }
    public static void SimpleMethod3()
    {

        Console.WriteLine("SimpleMethod3");
    }

}

// Where do you use multicast delegates?
// Ans: Multicast delegates makes implementation of observer design pattern very simple. observer pattern is also called as publish/ subscribe pattern.