using System;
using System.Collections;
using System.Collections.Generic;
// find() method to the list class loop through each object from the list until it does not found match. 
// So if you want to lookup the speed then use key value dictionary is for better performance over list.
// SO use dictionary when you know the collection will be primarily used for lookups.
namespace Amol
{
    public class whenToUseDictionaryOverList
    {
        public static void RunDictionaryOverList()
        {

            Country country1 = new Country() { Name = "India", Code = "IND", Capital = "Delhi" };
            Country country2 = new Country() { Name = "America", Code = "USA", Capital = "New York" };
            Country country3 = new Country() { Name = "Austalia", Code = "AUS", Capital = "Canberra" };
            Country country4 = new Country() { Name = "Canada", Code = "CAN", Capital = "ottwa" };

            // We are using list over dictionary
            //List<Country> list = new List<Country>();
            //list.Add(country1);
            //list.Add(country2);
            //list.Add(country3);
            //list.Add(country4);

            // using dict for better performance 
            Dictionary<string, Country> dict= new Dictionary<string, Country>();
            dict.Add(country1.Code, country1);
            dict.Add(country2.Code, country2);
            dict.Add(country3.Code, country3);
            dict.Add(country4.Code, country4);

            string strUSerChoice = "";
            do
            {
                Console.WriteLine("Please enter country code");
                string countryCode = Console.ReadLine().ToUpper();

                //Country resultCountry = list.Find(country => country.Code == countryCode);

                Country resultCountry =dict.ContainsKey(countryCode) ? dict[countryCode]:null;   // using dict instead of list find method for better performance.

                if (resultCountry != null)
                {
                    Console.WriteLine("Country code is not valid");
                }
                else
                {
                    Console.WriteLine("COuntry name ={0} && Code ={1}", resultCountry.Name, resultCountry.Code);
                }
                do
                {
                    Console.WriteLine("Do You want to continue Yes/ No ?");
                    strUSerChoice = Console.ReadLine().ToUpper();
                } while (strUSerChoice != "No" && strUSerChoice != "Yes");

            } while (strUSerChoice == "Yes");

        }
    }

    public class Country
    {

        public string Name { get; set; }
        public string Code { get; set; }
        public string Capital { get; set; }
    }
}
