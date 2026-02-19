using System;
using System.Collections.Generic;
using System.Text;

namespace Amol
{
    public class SortListWithSimpleTypes
    {
        public static void RunSortSimpleType()
        {


            // For Integer
            List<int> numbers = new List<int>() { 1, 4, 6, 2, 8, 9, 33, 44 };

            Console.WriteLine("Numbers before sorting");

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            numbers.Sort();

            Console.WriteLine("Numbers after sorting");

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            numbers.Reverse();
            Console.WriteLine("Numbers after decending sorting");

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }


            // For string


            List<string> alphabets = new List<string>() { "B", "F", "D", "S", "W", "R" };

            Console.WriteLine("alpabets before sorting");

            foreach (string item in alphabets)
            {
                Console.WriteLine(item);
            }
            alphabets.Sort();

            Console.WriteLine("alpabets after sorting");

            foreach (string item in alphabets)
            {
                Console.WriteLine(item);
            }

            alphabets.Reverse();
            Console.WriteLine("alphabets after decending sorting");

            foreach (var item in alphabets)
            {
                Console.WriteLine(item);
            }



        }
    }
}
