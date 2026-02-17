using System;
// I have added different physical file here to just understand how the partial things work.
// A partial class or structs can contain partial methods as well.
// A partial methods is created using partial keyword
// A Partial method always private by Default
// A partial method should have void return type.
// This implementation is optional.
// without partial keyword method would be considered as public method.
// Signature should be same as method definition. like params passing etc to that method.
// A partial method should be include in partial class or partial structs.will get compile time error
// A partial method should be delcared only once . if we try to create more than one then will get compile time error.

namespace Amol
{
    public class partialMethods
    {
        public static void RunPartialMethods()
        {
            SamplePartialClass sp = new SamplePartialClass();
            sp.getFirstName();
        }
    }

    //-----------------------------------------------------------------------------------------------------------------------
    // This is partial class and partial methods here.
    public partial class SamplePartialClass
    {
        partial void partialMethodCalled();            // this will thorw error because we already have used this method in below class. 

        public void getFirstName()
        {
            Console.WriteLine("Public method invoked");
            partialMethodCalled();
        }

    }
    //-----------------------------------------------------------------------------------------------------------------------

    // Below is the same name partial class which will be in different physical file 
    // which has partial method body to print console.
    // But above class just have method definition
    // When we create instance of that class in main class then automatically it will print even above class doesn't have body of that method.

    /* 
      
         public partial class SamplePartialClass
          {
              partial void partialMethodCalled();
              partial void partialMethodCalled()      
              {

                  Console.WriteLine("partialMethodCalled");
              }

              public void getFirstName()
              {

                  Console.WriteLine("Public method invoked");
                  partialMethodCalled();
              }

          }

    */
}
