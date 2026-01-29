using System;
// We are using Enum in this class with example
// we have replaced few things using enums.
// Now it become more readable and maintainable.
// Next file we will see why enum is required  refer-- Next file
public class UsingEnums
{
    public static void RunUsingEnums()
    {

        CustomerNewClass[] customer = new CustomerNewClass[3];

        //3)  we will change here Gender property values using Gender Enums.
        customer[0] = new CustomerNewClass
        {
            Name = "mark",
            Gender = Gender.Male,
        };
        customer[1] = new CustomerNewClass
        {
            Name = "marry",
            Gender = Gender.Female,
        };
        customer[2] = new CustomerNewClass
        {
            Name = "Sam",
            Gender = Gender.Unknown,
        };

        foreach (CustomerNewClass c in customer)
        {
            Console.WriteLine("Name={0} && Gender ={1}", c.Name, GetGender(c.Gender));
        }
    }

    // This is second method
    public static string GetGender(Gender gender) //2)  we will do second change here params type and case type.
    {
        switch (gender)
        {

            case Gender.Unknown:
                return "Unknown";
            case Gender.Male:
                return "Male";
            case Gender.Female:
                return "Female";
            default:
                return "Invalid data detected";

        }


    }
}

// This is a enum. which is using everywhere in this current program.
public enum Gender
{

    Unknown,
    Male,
    Female
}

public class CustomerNewClass
{
    public string Name { get; set; }
    public Gender Gender { get; set; }  //1)  we will change first here type of Gender

}
