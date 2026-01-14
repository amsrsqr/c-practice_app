using System;
using teamA = projectA.teamA;
using teamB = projectA.teamB;

// A namespace can contain
// 1) Another namespace
// 2) Class
// 3) interface
// 4) struct
// 5) enum
// 6) delegate

// Either we can create a seperate project & we can move below both name spaces in individual project
// and that namespacess we can access in current project.

class NameSpaces
{

    public static void RunNamespaces()  // This is a main method but to run this file we have only created one main method in ifElseSwitch.cs file
    {
        // Either we can access namespace class method this way

        /*
         projectA.teamA.classA.print();
         projectA.teamB.classB.print(); 
        */

        // OR this way
        teamA.classA.print();
        teamB.classA.print();

    }
}

namespace projectA
{
    namespace teamA
    {
        class classA         // Same class name in both namespaces that could show ambiguity error in import statement.
        {                    // So using aliases directives using "=" in import statement.
            public static void print()
            {
                Console.WriteLine("Team A print method");
            }
        }
    }
}

namespace projectA
{
    namespace teamB
    {
        class classA
        {
            public static void print()
            {
                Console.WriteLine("Team B print method");
            }
        }
    }
}