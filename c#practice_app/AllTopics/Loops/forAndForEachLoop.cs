using Microsoft.VisualBasic;
using System;
using System.Security.Cryptography;


class ForAndForEachLoop
{

    public static void RunForAndForEach()
    {
        int[] Numbers = new int[3];
        Numbers[0] = 101;
        Numbers[1] = 102;
        Numbers[2] = 103;


        // Using while loop 
        // Using this loop condition should be satisfy otherwise it could continuesly to execute.
        int i = 0;
        while (i < Numbers.Length)
        {
            Console.WriteLine("Using While Loop {0}", Numbers[i]);
            i++;
        }

        // Using for loop 
        // Important: It can thorw exception if we add any wrong condition after inside for loop;
        for (int j = 0; j < Numbers.Length; j++)
        {
            Console.WriteLine("Using For Loop {0}", Numbers[j]);
        }

        // Using foreach loop
        // Important: it does not throw indexOutOfRangeException // Always use in .Net loops;
        foreach (int k in Numbers)
        {
            Console.WriteLine("Using Foreach Loop {0}", k);
        }

        // Using Break Statement in loops
        // Will print output upto only 10 after this loop will break and terminate;
        for (int k = 0; k <= 20; k++)
        {
            Console.Write(k + " ");
            if (k == 10)
            {
                break;
            }
        }


        //This will print only even numbers
        for (int m = 0; m <= 20; m = m + 2)
        {
            Console.Write(m + " ");
        }


        // This will also print even numbers
        // “The continue statement skips to print console when the number is odd, so only even numbers are printed.”
        for (int m = 0; m <= 20; m++)
        {
            if (m % 2 == 1) continue;
            Console.Write(m + " ");
        }

    }

}