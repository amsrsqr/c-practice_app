using System;
// Private members are available only within the containing class.
// protected members are available within the containing means same class and it's derived class.

public class CustomerProtected
{
    // This protected member acessible in other class only when it derived to another class
    protected int id;

}

public class CustomerProtected2 : CustomerProtected  // this is derived statement.
{
    public void printId()
    {
        CustomerProtected2 c1 = new CustomerProtected2();
        c1.id = 101;                                      // Here is the access of protected members. using derived statement.
        base.id = 102;                                    // You access this way & 
        this.id = 103;                                    // You access this way as well.
    }
}

public class CustomerPrivateAndPublic   // This is a standalone class
{

    // Private fields only accessible within the same class.
    private int id;

    // Public fields are accessible everywhere from one class to another class using class instance (constructor). No restriction.
    public int Id
    {

        get { return id; }
        set { id = value; }
    }
}

public class publicPrivateProtected
{
    public static void RunPublicPrivateProtcted()
    {
        //CustomerAccess c1 = new CustomerAccess();
        //Console.WriteLine(c1.id); ----> This id could not be accessible due to private field.


    }
}
