using System;
using System.Collections.Generic;
// Attribute allows you to add declarative information to your program. This information can then be queried at runtime using reflection.
// All attribute are dervied from base class attribute.System.atribute base class
// Right click on absolete & go to definition you will have three types of absolete methods.
// There is predefined attributes in .Net 1) absolete 2) WebMethod 3)Serializable
public class AttributeBasics
{
    public static void RunBasicAttribute()
    {

        Calcualtor.Add(new List<int>(){ 10, 20, 30 });
    }
}

public class Calcualtor
{
    //[ObsoleteAttribute("Add(List<int> Numbers)", true)]  // If we pass true then we cannot use below first add method that will give error
    // This method add limitation on paramters.
    [ObsoleteAttribute("Add(List<int> Numbers)")]  // [ObsoleteAttribute] -- this attribute word is optional we can write only [Obsolete]
    public static int Add(int firstNumber, int secondNumber)
    {
        return firstNumber + secondNumber;
    }

    // This method allow limitless paramters using list of integers.
    public static int Add(List<int> Numbers)
    {
        int sum = 0;
        foreach (int number in Numbers)
        {
            sum = sum + number; ;
        }
        return sum; ;
    }
}