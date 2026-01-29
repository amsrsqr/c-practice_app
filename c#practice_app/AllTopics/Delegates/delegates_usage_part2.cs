using System;
using System.Collections.Generic; // because we are using List collection

// Updated delegate_usage file with delegates refer this file and then come to this file to understand delegates usage part 2
public class DelegatesUsagePart2
{
    public static void RunUsageDelegates() // public static void Main()
    {
        List<EmployeesList> employeeList = new List<EmployeesList>();
        employeeList.Add(new EmployeesList() { Id = 1, Name = "John", Salary = 50000, Experience = 5 });
        employeeList.Add(new EmployeesList() { Id = 1, Name = "Mary", Salary = 40000, Experience = 4 });
        employeeList.Add(new EmployeesList() { Id = 1, Name = "Mark", Salary = 30000, Experience = 3 });
        employeeList.Add(new EmployeesList() { Id = 1, Name = "Ammy", Salary = 60000, Experience = 6 });

       // you can use lambda expression also like below
       
        EmployeesList.PromoteEmployee(employeeList, emp=>emp.Experience>=5); // pass boolean expression directly

    }

}

delegate bool IsPromotable(EmployeesList empl);  // declaring a delegate

class EmployeesList
{
    public int Id { get; set; }
    public string Name { get; set; }

    public int Salary { get; set; }

    public int Experience { get; set; }


    public static void PromoteEmployee(List<EmployeesList> employeeList, IsPromotable IsEligibleToPromote) // passing delegate as parameter
    {

        foreach (EmployeesList employee in employeeList)
        {
            if (IsEligibleToPromote(employee))  // using that params
            {
                Console.WriteLine(employee.Name + " Promoted");

            }
        }
    }
}