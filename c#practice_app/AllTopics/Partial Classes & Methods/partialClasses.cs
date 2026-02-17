using System;
// What are partial classes?
// what is adavntages of partial classes 
// Where we used partial classes?
// Suppose below class need to split into two different physical file then we used partial.
// Advanatges : 
// 1) The main adavtages is that visual studio uses partial classes to seperate automatically genenrated system code from developers code.
// 2) when you add webform.cs then CS file are generated
// a) WebForm.aspx.cs  -- Contain developers code
// b) WebForm.aspx.designer.cs  -- Contain system generated code

// We have added two file to understand partial classes 
 // 1) partialClassOne.cs
 // 2) partialClassTwo.cs
// where we have added code of this file in one file we have added get and set methods and in two file we have added getFullName method 
// we can create instance of that class as well to get all those details.
namespace Amol
{
    public class partialClasses
    {
        // Always declare above main method.
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }

        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string getFullName()
        {
            return firstName + " " + lastName;
        }
    }

}
