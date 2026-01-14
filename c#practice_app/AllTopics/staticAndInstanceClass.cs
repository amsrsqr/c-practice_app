using System;

// We called a static member who has static keyword initial. can access using class names
// We called a instance member who does not have static keyword initial.can access using this keyword
// why we should have to create staic field
// Because PI value is always same it could not change according to program so it should be static means it is always a constant. it does create only one copy in memory
// We can make only those field instatnce member which is going to change over a time / program. it create duplicate copy in memory

class Cirlce
{
    // This below all the method and varaible are instance member without initial static keyword ex. static float _PI=3.242
    float _PI = 3.141F;   
    int _radius;


    public Cirlce(int radius)  // This is a instance consturctor;
    {
        this._radius = radius;
    }

    // Static constructor always called before anything in the program.like before any object, methods or even before instance constructor.
    // if we make PI with static like as below

    // then we cannot use "this" keyword to access it in class 
    /* static float _PI; */

    // we should have to access like as below using className.
    /* Circle.PI */

    // Below is static constructor. which is used for to initialized only static member like method or variables.

     /*
      static Circle() { 
        Cirlce.PI= 3.141F;
      } 
     */

    public float CalculateArea()
    {
        return this._PI * this._radius * this._radius;
    }
}

class StaticAndInstanceClass {

    public static void RunStaticInstanceClass() {  // This is main class method which is public static void main() like this.
        Cirlce c1 = new Cirlce(5);
        float area = c1.CalculateArea();
        Console.WriteLine("Area is {0}", area);

    }
}


// If we make any constructor without access modifier then it will make automatacally private.
// It mean you can only access that member within the same class not outside of the class.
