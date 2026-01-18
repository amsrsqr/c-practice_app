using System;

class DoWhile
{
    public static void RunDoWhile()
    {
        string userChoice = string.Empty;  // "" or null
        do
  //--
        {
            Console.WriteLine("Please enter your number");
            int yourNumber = int.Parse(Console.ReadLine());
            int start = 0;
            while (start <= yourNumber)
            {
                Console.Write(start + " ");
                start = start + 2;
            }
            do                                                            // this is inner block
            {
                Console.WriteLine("Do you want to continue yes or no");
                userChoice = Console.ReadLine().ToUpper();

                if (userChoice != "YES" && userChoice != "NO")
                {
                    Console.WriteLine("Please enter valid type like yes or no");
                }
            } while (userChoice != "YES" && userChoice != "NO");
 //--
        } while (userChoice == "YES");
    }
}