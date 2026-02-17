using System;


namespace Amol
{
    public class OverloadingIndexers
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }

    public class IndexerChild
    {
        private List<OverloadingIndexers> listEmployees;

        public IndexerChild()
        {
            listEmployees = new List<OverloadingIndexers>();

            listEmployees.Add(new OverloadingIndexers
            { EmployeeId = 1, Name = "Mike", Gender = "Male" });
            listEmployees.Add(new OverloadingIndexers
            { EmployeeId = 2, Name = "Pam", Gender = "Female" });
            listEmployees.Add(new OverloadingIndexers
            { EmployeeId = 3, Name = "John", Gender = "Male" });
            listEmployees.Add(new OverloadingIndexers
            { EmployeeId = 4, Name = "Maxine", Gender = "Female" });
            listEmployees.Add(new OverloadingIndexers
            { EmployeeId = 5, Name = "Emiliy", Gender = "Female" });
            listEmployees.Add(new OverloadingIndexers
            { EmployeeId = 6, Name = "Scott", Gender = "Male" });
            listEmployees.Add(new OverloadingIndexers
            { EmployeeId = 7, Name = "Todd", Gender = "Male" });
            listEmployees.Add(new OverloadingIndexers
            { EmployeeId = 8, Name = "Ben", Gender = "Male" });
        }

        public string this[int employeeId]
        {
            get
            {
                return listEmployees.
                    FirstOrDefault(x => x.EmployeeId == employeeId).Name;
            }
            set
            {
                listEmployees.
                    FirstOrDefault(x => x.EmployeeId == employeeId).Name = value;
            }
        }
        // This is we have added for string indexer parameters.
        // If we pass second params then it will build success if it is not same above method.
        // This overload indexer using different parameters.
        public string this[string gender]
        {
            get
            {
                return listEmployees.Count(x => x.Gender == gender).ToString();  // we used count-- return type will be integer but converted into string
            }
            set
            {
                foreach (OverloadingIndexers employee in listEmployees)
                {
                    if (employee.Gender == gender)
                    {
                        employee.Gender = value;
                    }
                }
            }
        }


        /*
         
             IndexerChild shop= new IndexerChild();
                            
                 Console.WriteLine(shop["Female"]);           // This will return the count of that genders available

           // To set gender of the using string indexer

                 shop["Male"]="Female"  // for this 3 index.

         */

    }
}
