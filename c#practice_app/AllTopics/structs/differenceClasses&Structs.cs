using System;

// Struct is a value type where as a Class is a reference type
// Struct are stored on the stack memory where as Class are stored on the heap memory
// Value type hold their value in memory where they are declared but reference type hold only reference variable in memory (like m1).
// Value type destroyed immediately after the scope is lost (mean after {})
// Reference type only detroyed reference variable after the scope is lost (like m1)
// Reference type object later detroyed by Garbage Collector
// when a copy a struct to another struct, a new copy of the value is created & modification in new copy not affect original struct
// When a copy a class to another class, both classes point to the same object in heap memory & modification in new class affect original class
// Struct can't have destructor but Class can have destructor. Destructor name should be as class name prefixed with ~ (tilde) symbol.
/*
       public struct Manager{
         ~Manager(){             // This line will give error because struct can't have destructor
             // destructor code
         }

      public class Manager{
         ~Manager(){             // This line will work because class can have destructor
             // destructor code
         }
 */
// Sealed class can't be inherited
// Struct are sealed by default so it can't be inherited
public class Manager
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class DifferenceClassesAndStructs
{
    public static void RunDifferenceClassesAndStructs()  // public static void Main()
    {
        // This int i and j is struct type means it is value types (Hover & check)
        int i = 10;
        int j = i;
        j = j + 1;

        Console.WriteLine("i ={0} && j ={1}", i, j);            // Output : i= 10 && j= 11;

        // This Manager is class type means it is reference types.
        Manager m1 = new Manager();                             // m1 will point to object stored in heap memory
        m1.Id = 10;
        m1.Name = "Mark";

        Manager m2= new Manager();                             // m2 will point to that same object stored in heap memory
        m2.Name = "John";                                      // So output will be John for both m1 and m2

        Console.WriteLine("m1 = {0} && m2 ={1}", m1.Name, m2.Name);  // Output : m1= John && m2= John;
    }
}