using System;

// Inheritance is one of the primary pillar of object oriented programming language.
// Inheritance allows code reuse
// Code reuse can reduce time and errors.
// Note: You will specifiy all the common fields, properties and methods in base class. Which allows code reusability. 
// C# supports only single class inheritance
// c# multiple class inheritance is not supported but supports multiple interface inheritance ex.as below
// c# multi level class inheritance supported.
// When inherit from parent to child then first parent class get called first then child
public class Employee {
    // This make common for both below classes.
    // Make public because this could access by any derived class.
    public string firstName;
    public string lastName;
    public string email;

    public void getFullName() { 
     Console.WriteLine(firstName + " " + lastName); 
    }
}

// This is syntax of inheritance
public class FullTimeEmployee : Employee
{
    // child class
    public float yearlySalary;
}

// public class PartTimeEmployee : Employee, NewMultiClass // This multiple class inheritance is not supported will give compile time error
public class PartTimeEmployee : Employee
{
    // child class
    public float hourlySalary;
}

// But below multi level inheritance is supported as below ex. Parttime to employee == NewMultiClass to parttime
public class NewMultiClass: PartTimeEmployee { 

}
class InheritanceProgram {

    //public static void Main() { 
    public static void RunInheritance() { 
    FullTimeEmployee FTE= new FullTimeEmployee();
        FTE.firstName = "Amol";
        FTE.lastName = "Rashinkar";
        FTE.email = "amol@gmail.com";
        FTE.yearlySalary = 50000;
        FTE.getFullName();
    PartTimeEmployee PTE= new PartTimeEmployee();
        PTE.firstName = "Akash";
        PTE.lastName = "Shinde";
        PTE.email = "akash@gmail.com";
        PTE.hourlySalary = 10000;
        PTE.getFullName();
    }
}

// Below is the example for inheritance of class with overriding constructor.

//public class ParentClass {

//    // This is constructor with round bracket ()
//    public ParentClass() {
//        Console.WriteLine("Parent class called");
//    }
//    // This is override same constructor with params
//    public ParentClass(string title) {
//        Console.WriteLine(title);
//    }
//}

//public class ChildClass : ParentClass {
//    public ChildClass():base("Child class called to parent class method") {  // This base is used to call the override constructor. 
//        Console.WriteLine("Child class Called");
//    }
//}

//public class Program{
//    public static void Main() {
//        ChildClass cc = new ChildClass();
//    }
//}

// Output 
// Child class called to parent class method
// Child class Called