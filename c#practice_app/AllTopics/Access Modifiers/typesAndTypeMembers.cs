using System;
// In this example generalExample class is a Type and fields , Properties and method are type members.
// So in general classes, structs, enums, interfaces, delegates are called types and it's fields and properties, constructor, methods are types members
// in C# There are 5 different access modifier.
/*
  1) Public 
   2) Private 
    3) Protected 
     4) Internal 
      5) Protected Internal
 */
// Type members can have all this access modifiers but type have only two access modifiers which is public and internal.

class generalExample {  // This className is Type 

    // This region is used to collapsed and expand below code until endRegion statement.
    #region  
    // This belows are class members means types members.
    public int id;
    private string firstName;
    protected string lastName;
    #endregion

    #region
    public int Id{
        get { return id; }
        set { id = value; }
    }
    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }

    }
    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }
    #endregion
}
public class typesAndTypeMembers
{
    public static void RunTypesAndTypeMember()
    {


    }
}
