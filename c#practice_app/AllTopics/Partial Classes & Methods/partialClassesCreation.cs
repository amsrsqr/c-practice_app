using System;
// If you make any of them class as abstract then the other same name partial classes would be considered as abstract.
// You can create instance of that abstract class. You will get runtime error.
// If you create any class with sealed keyword then you cannot use that class as base class for another class like inheritance sampleClass: baseClass(Sealed).
// If you inherit any of them class with other base class then both of that class will be automatically inherit from the same base class.
// We cannot inherit this two partial class from two different base classes.because C# doesn't support multiple inheritance.
// If you inherit these two partical class from two different interfaces then it will work. but you just have to add mentioned all method in that class.
// You can access all other methods as well when you inherit using interface.
/* IMPORTANT POINTS AS BELOW */

/*
  1) All the spread parts of class in different file should have partial keyword.
  2) All the spread parts of class in different file should have same access modifier
  3) If any of the type is created as abstract then entire type considered as abstract
  4) If any of the parts is created as sealed then entire type considered as sealed & it does not use as base class
  5) If any part of inherit any class then the entire type considerd as inherit from that class.
 */

namespace Amol
{
    public class partialClassesCreation
    {
        public static void RunCreatePartialClass()
        {


        }
    }
    //--------------INTERFACES------------------
    public interface IClassOne
    {
        public void getFullNameOne();
    }
    public interface IClassTwo {

        public void getFullNameTwo();
    }

    //-------------------PARTIAL CLASSES--------------------------
    public partial class partialClassCreateOne : IClassOne
    {
        public void getFullNameOne()
        {

        }

    }

    public partial class partialClassCreateTwo : IClassTwo
    {
        public void getFullNameTwo()
        {

        }

    }



}
