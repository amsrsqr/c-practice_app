using System;

// Polymorphism is one of the primary pillars of the OOPS.
// Polymorphism allows you to invoke derived class methods through a base class reference during runtime.
// In the base class the method is declared as virtual , and in child class we override the base method.
// The virtual keyword indicates, the method can overriden in any derived class(child class).
class ParentMember
{
    public string FirstName = "Poly";
    public string LastName = "Morph";
    public virtual void getFullName()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }

}

class ChildMemberOne : ParentMember
{
    public override void getFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + " member one");
    }

}
class ChildMemberTwo : ParentMember
{
    public override void getFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + " member two");
    }
}
class ChildMemberThree : ParentMember
{
    // If we not write any method in child class then forEach loop will print default full name from base class.
    // Because we are assigining parent class to this child class.
    // default behaviour will like this.
    public override void getFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + " member three");
    }
}
class Polymorphism
{
    public static void RunPolymorphism() // Public static void Main() will be replaced here.
    {
        ParentMember[] member = new ParentMember[4];

        member[0] = new ChildMemberOne();
        member[1] = new ChildMemberTwo();
        member[2] = new ChildMemberThree();
        member[3] = new ParentMember();

        foreach (ParentMember mem in member)
        {
            mem.getFullName();
        }

        //Output Will be: 
        //Poly Morph member one
        //Poly Morph member two
        //Poly Morph member three
        //Poly Morph

    }
}