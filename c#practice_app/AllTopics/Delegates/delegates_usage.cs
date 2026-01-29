using System;
using System.Collections.Generic; // because we are using List collection

// This is a just code to demonstrate the usage of Delegates in C#
// but we have not implemented delegates here just a simple example to promote employees based on experience
// Please see third file of delegates to actual usage of delegates in C#

public class DelegatesUsage
{
    public static void RunUsageDelegates() // public static void Main()
    {
        List<EmployeeList> empList = new List<EmployeeList>();  // we have imported collection to access list
        empList.Add(new EmployeeList() { Id = 1, Name = "John", Salary = 50000, Experience = 5 });  // this promoted in output
        empList.Add(new EmployeeList() { Id = 1, Name = "Mary", Salary = 40000, Experience = 4 });
        empList.Add(new EmployeeList() { Id = 1, Name = "Mark", Salary = 30000, Experience = 3 });
        empList.Add(new EmployeeList() { Id = 1, Name = "Ammy", Salary = 60000, Experience = 6 });  // this promoted in output

        EmployeeList.PromoteEmployee(empList); // we can directly call this method because this method makes static
       
        // If we removed static then we can access like this

        //EmployeeList emp = new EmployeeList();
        //emp.PromoteEmployee(empList);
    }

}

class EmployeeList
{
    public int Id { get; set; }
    public string Name { get; set; }

    public int Salary { get; set; }

    public int Experience { get; set; }


    public  static void PromoteEmployee(List<EmployeeList> employeeList)
    {

        foreach (EmployeeList employee in employeeList)
        {
            if (employee.Experience >= 5)
            {
                Console.WriteLine(employee.Name + " Promoted");

            }
        }
    }

}