using System;
// If you want to hide parent class memeber in child then use "new" keyword.
public class Parent
{
    public string FirstName;
    public string LastName;

    public void getFullName()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }
}

public class MyNewParent : Parent
{
    public new void getFullName()   // Use this new keyword if you want to hide parent method then.
    {
        base.getFullName();        // Use to call the base class method which is earlier written in base class
        Console.WriteLine(FirstName + " " + LastName + "- contractor");
    }
}

class MethodHinding
{
    //public static void Main() { 
    public static void RunInheritance()
    {
        MyNewParent FTE = new MyNewParent();
        FTE.FirstName = "Amol";
        FTE.LastName = "Rashinkar";
        FTE.getFullName();

        ((Parent)FTE).getFullName(); // To call directly parent class method from here use this (type casting)
        //Parent FTE = new MyNewParent();  You can use to call parent class method
        // MyNewParent FTE = new Parent(); This can give us error because child class cannot fullfill the base class requirements.
    }
}
