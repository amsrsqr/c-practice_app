using System;
// Why Enum is strongly typed constant ? that is shown in below ex.
// So we need explicit cast needed to conver enum type to integral type.
// it is possible to customize enum values like below commented example
// Enum values can automatically increment by 1. Please check on hover mouse on enum values.


public class WhyEnumIsRequired
{
    public static void RunWhyEnumRequired()
    {

        Gender gender = (Gender)SeasonEnum.winter; // Explicit type can be possible here using (Gender)

        short[] intValues = (short[])Enum.GetValues(typeof(HumanGender)); // to call the Enum class method which will return int numbers. 

        foreach (short value in intValues)
        {
            Console.WriteLine(value); // like 0,1,2

        }
        string[] stringValues = (string[])Enum.GetNames(typeof(HumanGender)); // to call the Enum class which will return string names.

        foreach (var item in stringValues)
        {
            Console.WriteLine(item); // like Unknow,Male,Female
        }
    }
}

//Change underline type here.
// Here enum is enumerations
// & Enum is class which has static methods like GetNames and GetValues.
public enum HumanGender : short   // Without short it will be default Int & If we make this short then have to change manually in intValues.
{
    // We can make like this as well. We can give any number to this values.But we cannot give large number like 32313123123.
    //Unknown =1,
    //Male=2,
    //Female=3

    Unknown,
    Male,
    Female
}

public enum SeasonEnum
{

    winter = 1,
    Spring = 2,
    Summer = 3,
}
