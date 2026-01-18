using System;

class Methods
{

    // Methods should have access modifier 
    // ex. as below format should be for any methods to define.
    /*
         [attribute]
           access-modifier return-type method name(parameters) 
           { 
             method body
           } 
    */
    // method name should be meaningful name except reserve keywords
    // parameters are optional
    // main method can have access modifier
    public static void RunMethods()
    {
        Methods.EvenNumber(30);                // which can access static methods using this
        //EvenNumber(30);                      // This can also work to access static methods
        Methods m = new Methods();             // Instance of class used for to access instance method
        int sum = m.sumNumber(10, 20);         
        Console.WriteLine("Sum=>{0}", sum);
    }

    // This method is called as instance method.
    // It does not have static keyword.
    public int sumNumber(int sn, int fn)
    {
        return sn + fn;
    }

    // This is a static method of class using static keyword.
    public static void EvenNumber(int target)
    {
        int start = 0;
        while (start <= target)
        {
            Console.WriteLine(start);
            start = start + 2;
        }

    }

}