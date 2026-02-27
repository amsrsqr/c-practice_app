using System;

namespace Amol
{
    public class lambdaExpression
    {

        // Anonymous methods and Lambda expressions are very similar.Anonymous methods were introduced in C# 2 and Lambda expressions in C# 3. 

        // To find an employee with Id = 102, using anonymous method
        // Employee employee = listEmployees.Find (delegate (Employee Emp) { return Emp.ID == 102; });

        // To find an employee with Id = 102, using lambda expression
        // Employee employee = listEmployees.Find(Emp => Emp.ID == 102);

        // You can also explicitly specify the Input type but not required
        // employee = listEmployees.Find((Employee Emp) => Emp.ID == 102);

        // Notice that with a Lambda expression you don't have to use the delegate keyword explicitly and you don't have to specify the input parameter type explicitly.The parameter type is inferred.Lambda expressions are more convenient to use than anonymous methods.Lambda expressions are particularly helpful for writing LINQ query expressions.

        // => is called lambda operator and read as GOES TO.

        // In most of the cases Lambda expressions supersedes anonymous methods. To my knowledge, the only time I prefer to use anonymous methods over lambdas is, when we have to omit the parameter list when it's not used within the body. 

        // Anonymous methods allow the parameter list to be omitted entirely when it's not used within the body, where as with lambda expressions this is not the case.
    }
}
