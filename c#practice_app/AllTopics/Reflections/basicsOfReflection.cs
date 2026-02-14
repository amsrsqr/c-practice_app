using System;
using System.Reflection; // 
// Basics of relection
// Reflection is the ability of insepcting an asemblies metadata at runtime
// it is used to find all methods which is exist in assemblies.
// Asselies generate in two forms when we build application
// 1) about static assemblies is create executable files with .exe extension
// 2) About meta data of class like varaible methods and many more // this is reflections.
// late binding reflection means we can access another class varaibles using instance of that class.i.e compile time

namespace Amol
{
    public class BasicsOfReflection
    {
        private static void RunBasicReflection()
        {
            Type t = Type.GetType("Amol.BasicsClassOfReflection");      // Type exist in System namespace
            // t.Name                                                   // This way we can get values.
            // t.Id

            // Type t = typeOf(BasicsClassOfReflection)                 // You can use instead of above statement
            PropertyInfo[] properties = t.GetProperties();              // used this namesapce ---- using System.Reflection;
            foreach (PropertyInfo item in properties)
            {
                Console.WriteLine(item.PropertyType.Name ,item.Name);   // Two ways to get Name using reflection
            }

                                                                        // for method we can use 
                                                                        //1) MethodInfo
                                                                        // 2) GetMethods()

                                                                        // For constructor
                                                                        //1) ConstructorInfo
                                                                        //2) GetConstructor()
        }
    }

    public class BasicsClassOfReflection
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public BasicsClassOfReflection(int Id, string Name)
        {

            this.Id = Id;
            this.Name = Name;
        }
    }
}


