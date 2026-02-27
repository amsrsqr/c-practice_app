using System;
using System.Linq.Expressions;
using System.Reflection.Metadata;
// the purpose of Func<T, TResult> delegate in c# with an example.
// What is Func < T, TResult > in C#?
// In simple terms, Func<T, TResult> is just a "generic delegate".
// Depending on the requirement, the type parameters (T and TResult) can be replaced with the corresponding type arguments. 
// For example, Func<Employee, string> is a delegate that represents a function expecting Employee object as an input parameter and returns a string.


namespace Amol
{
    public class funDelegatesInCSharp
    {
        public static void RunFunDelegatesInCSharp()
        {

        List<Employee> listEmployees = new List<Employee>(){
            new Employee{ ID = 101, Name = "Mark"},
            new Employee{ ID = 102, Name = "John"},
            new Employee{ ID = 103, Name = "Mary"},
          };

            // Create a Func delegate
            Func<Employee, string> selector =
                employee => "Name = " + employee.Name;
            // Pass the delegate to the Select() LINQ function
            IEnumerable<string> names = listEmployees.Select(selector);

            // The above output can be achieved using
            // lambda expression as shown below
            // IEnumerable<string> names =
            // listEmployees.Select(employee => "Name = " + employee.Name);

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            // Q2 What if I have to pass two or more input parameters?
            // Example of above questions which is mentioned with theory as below.
            Func<int, int, string> funcDelegate = (firstNumber, secondNumber) => "Sum = " + (firstNumber + secondNumber).ToString();
            string result = funcDelegate(10, 20);
            Console.WriteLine(result);
        }

        public class Employee
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }
    }
}

// Q1.What is the difference between Func delegate and lambda expression?
// They're the same, just two different ways to write the same thing. The lambda syntax is newer, more concise and easy to write.

// Q2 What if I have to pass two or more input parameters?
// As of this recording there are 17 overloaded versions of Func, which enables us to pass variable number and type of input parameters.
// In the example below, Func<int, int, string> represents a function that expects 2 int input parameters and returns a string.

// Q3 So what is the use of async and await keywords in C#
// async and await keywords are used to create asynchronous methods.
// The async keyword specifies that a method is an asynchronous method and the await keyword specifies a suspension point.
// The await operator signalls that the async method can't continue past that point until the awaited asynchronous process is complete.
// In the meantime, control returns to the caller of the async method.


// You may have a few questions at this point. 
// 1. Can't we achieve the same thing using a Thread. 
// 2. What is the difference between a Thread and a Task
// 3. When to use a Task over Thread and vice-versa