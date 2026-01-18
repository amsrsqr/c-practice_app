using System;

public class SwitchGoto {
    public static void Run() // public static void main() like this.
    { 
        int totalCoffeeAmount = 0;

    start:
        Console.WriteLine("Please Select Your Coffee: 1-small 2-medium 3-large");
        int myCoffeeSize = int.Parse(Console.ReadLine());
   
        switch (myCoffeeSize)
        {
            case 1:
                totalCoffeeAmount += 10;
                break;
            case 2:
                totalCoffeeAmount += 20;
                break;
            case 3:
                totalCoffeeAmount += 30;
                break;
            default:
                Console.WriteLine("Please enter valid coffee size {0}", myCoffeeSize);
                break;
        }

    Decide:
        Console.WriteLine("Please choose another coffee: Yes/No");
        string anotherCoffee= Console.ReadLine();
        switch (anotherCoffee)
        {
            case "yes":
                goto start;
            case "no":
                break;
            default:
                Console.WriteLine("Please choose another coffee with valid option {0}", anotherCoffee);
                goto Decide;
        }
        Console.WriteLine("Thank You for shopping with us");
        Console.WriteLine("Your Bill Amount is{0}", totalCoffeeAmount);

    }

}