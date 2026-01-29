using System;

public class IfElseSwitch
{
    // This method will be common here to run all the program files from you AllTopics folder
    // import that class and hit the inside method
    // for example :SwitchGoto.Run();
    // Run the App;
     public static void Main()
    {
       WhyEnumIsRequired.RunWhyEnumRequired();
    }

    static void RunIfElse()
    {
        Console.WriteLine("Please enter your number");
        int myNum = int.Parse(Console.ReadLine());

        // This is normal If else conditions
        if (myNum == 10)
        {
            Console.WriteLine("Your number is 10");
        }
        else if (myNum == 20)
        {
            Console.WriteLine("Your number is 20");
        }
        else
        {
            Console.WriteLine("Your number is not 10 or 20 is something else");
        }

        // Below is simple switch statement with compulsory break statement
        switch (myNum)
        {
            case 10:
                Console.WriteLine("Your number is 10");
                break;
            case 20:
                Console.WriteLine("Your number is 20");
                break;
            case 30:
                Console.WriteLine("Your number is 30");
                break;
            default:
                Console.WriteLine("Your number is not 10,20 & 30");
                break;
        }

        // Below things Join multiple case statement together
        switch (myNum)
        {
            case 10:
            case 20:
            case 30:
                Console.WriteLine("Your number is {0}", myNum);
                break;
            default:
                Console.WriteLine("Your number is not 10,20 & 30");
                break;
        }
    }
}