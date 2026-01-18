using System;
// In c# to create encapsulate and protect fields we use properties get and set method.
// Encapsulation is one of the primary pillar of object oriented programming language.
// Encapsulation is the mechanism of wrapping the variables & methods together as a single unit.
// In encapsulation the variables of a class will be hidden from other class 
// can be accessed only through the methods of their current class. like get and set.
// Marking the class fields public and expose to other word is bad practice.
// If you do this then you will not have control what data assigned and what it returns.
class Student
{

    // If we are using this fields in other class then it should be not editable in other class
    // because it should be private to make it encapsulate from other class.
    // it is only accessible by using public get and set methods.
    private int id;
    private string name;
    private int passMark = 35;

    // If we make above field is priavte then it will not accessible outside the class.
    // So to make it accessible we use properties get and set method.                          // IMP

    // This is setter method to set the value of id.
    public void setId(int id)
    {
        if (id <= 0)
        {
            throw new Exception("Student Id cannot be less than or equal to zero");
        }
        else
        {
            this.id = id;
        }
    }

    // This is getter method to get the value of id.
    public int getId()                                               // Check return type
    {
        return this.id;
    }

    public void setName(string name)
    {
        if (string.IsNullOrEmpty(name)) { 
        throw new Exception("Student name cannot be null or empty"); // If name is empty then will throw this exception.
        }
        else
        {
            this.name = name;
        }
    }

    public string getName() {                                             // check return type for all get method
                                                                          // this No Name will return when we don't set any name value.
        return string .IsNullOrEmpty(this.name) ? "No Name" : this.name;  // Using ternary operator to check name is empty or not.
    }


    public int getPassMark()                              // Only getter method because this is constant value.
    {                                                     // Nobody will change this value.
        return this.passMark;
    }

}
class GetSetUnderstanding
{
    public static void RunGetSet() // public static void Main()
    {
        Student student = new Student();
        student.setId(101);                                            // This Id should be positiove or more than zero.
        Console.WriteLine(student.getId());
        student.setName("Amol");                                       // This name should not be empty.
        Console.WriteLine(student.getName());
        student.getPassMark();
        Console.WriteLine(student.getPassMark());                      // Get default and constant value of passMark.

    }
}