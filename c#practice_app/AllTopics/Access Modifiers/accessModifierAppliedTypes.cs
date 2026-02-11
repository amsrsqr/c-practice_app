using System;
// This is a types & type members acccess modifier
// If we does not specify access modifier to type it will be Internal e.g class
// If we does not specify access modifier to type member it will be Private e.g variable string name='Amol'; 

namespace assemblyOne
{
    public class assemblyOneClass    // If we does not declare here public type it will be internal by default
    {
        public void print()          // If we does not declare here public type it will be private by default
        {

        }
    }
}
// This below will be in new assembly means new project

namespace assemblyTwo
{
    public class assemblyTwoClass
    {
        public void test()
        {
            // As we can access above assembly method by using adding reference in assembly two so that we can able to access that method if classOne has public modifier.

        }
    }
}
