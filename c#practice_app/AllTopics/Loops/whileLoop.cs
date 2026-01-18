using System;

public class whileLoop { 
  
   public static void RunWhile()  // public static void Main() {
    { 

        Console.WriteLine("Please enter your number");
        int yourNumber = int.Parse(Console.ReadLine());
        int start = 0;
        while (start <=yourNumber) { 
            Console.WriteLine(start); // will print each number on new line
            Console.Write(start+" "); // will print each number in one line with single space
            start = start + 2;
        }
    }
}