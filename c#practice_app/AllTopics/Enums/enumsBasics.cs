using System;
// why Enums ?
// If the program uses set of integral number, Consider replacing them with enum so it will make more quality program.
// Enum is strongly typed constants.
// We will see in this sheet what will be problems with enums.
// Using switch is more non-maintainable and less readable
// In the next file will see how replace that switch
public class EnumsBasics
{

    // This is one method
    public static void RunEnumBasics()
    {
        CustomerClass[] customer = new CustomerClass[3];

        customer[0] = new CustomerClass
        {
            Name = "mark",
            Gender = 1,
        };
        customer[1] = new CustomerClass
        {
            Name = "marry",
            Gender = 2,
        };
        customer[2] = new CustomerClass
        {
            Name = "Sam",
            Gender = 0,
        };

        foreach (CustomerClass c in customer)
        {
            Console.WriteLine("Name={0} && Gender ={1}", c.Name, GetGender(c.Gender));
        }
    }

    // This is second method
    public static string GetGender(int gender)
    {
        switch (gender)
        {

            case 0:
                return "Unknown";
            case 1:
                return "Male";
            case 2:
                return "Female";
            default:
                return "Invalid data detected";

        }

    }

}

// If gender is "0" then it's unknown
// If gender is "1" then it's male
// If gender is "2" then it's female
public class CustomerClass
{
    public string Name { get; set; }
    public int Gender { get; set; }

}