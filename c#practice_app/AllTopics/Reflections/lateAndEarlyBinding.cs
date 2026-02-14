using System;
using System.Reflection;   // Used to load Assembly to create a class with late binding

// Most of the error shows at compile time for ex. spelling mistake, wrong func call that is early binding
// Differce between late binding and early binding
// 1) Early binding can flag error at compile time
// 2) Late binding there is risk of run time exception
// 3) Early binding is much better for performance than the late binding
// 4) Late binding only use when we wroking with an object which is not available at compile time

namespace Amol
{
    public class lateAndEarlyBinding
    {
        public static void RunLateBinding()
        {
            // This is early binding we comment it out for now.
            /** 
             
                lateBindingExample c1 = new lateBindingExample();
                string fullName = c1.getfullName("Amol", "Rashinkar");
                Console.Write("fullName= {0}", fullName);

            **/

            // This is below is late binding
            // In late binding Reflection We should have to do it everything manually
            // Suppose we doesn't have exist below lateBindingExample class

            Assembly assembly = Assembly.GetExecutingAssembly();                // This is exist in  System.Reflection; this namespace

            Type CustomType = assembly.GetType("Amol.lateBindingExample");      // this will return type of method 

            object customInstance = Activator.CreateInstance(CustomType);       // this activator exist in system namesapce will create instance of the class.

            MethodInfo getFullNameMethod = CustomType.GetMethod("getfullName");  // That custom type will create a new method

            string[] parameteres = new string[2];
            parameteres[0] = "Amol";
            parameteres[1] = "Rashinkar";

            //To  Create a method with accepting few param like firstName and lastName which is creating as below statement.

            string finalFullName = (string)getFullNameMethod.Invoke(customInstance, parameteres); // (string) explicitly converted into string

            Console.WriteLine("Final Full Name is ={0}", finalFullName);
        }
    }

    public class lateBindingExample
    {

        public string getfullName(string firstName, string lastName)
        {

            return firstName + " " + lastName; ;
        }
    }
}
