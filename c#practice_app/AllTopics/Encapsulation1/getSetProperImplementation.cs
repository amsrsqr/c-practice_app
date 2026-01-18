using System;

// We use get and set accessors to implement properties in c#
// A property with both get and set accessors is a read-write property.
// A property with only a get accessor is a read-only property.
// A property with only a set accessor is a write-only property.
class CollegeStudent
{

    private int _id;
    private string name;
    private int passMark = 35;
    //private string city;    // Instead of this we have used automatic property.
    //private string email;   // Instead of this we have used automatic property.

    // This is for Id property with read and write access.
    public int Id                                 // A single get set method OR it is a set accessor and get accessor property.
    {
        set
        {
            if (value <= 0)                      // this value means the value which is set in main class.
            {                                    // accessible here "value" params as c# default keyword.
                throw new Exception("Student Id cannot be less than or equal to zero");
            }
            else
            {
                this._id = value;
            }
        }
        get {
            return this._id;
        }
    }

    // This is for Name property with read and write access.
    public string Name
    {
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Student name cannot be null or empty");
            }
            else
            {
                this.name = value;
            }
        }
        get
        {
            return string.IsNullOrEmpty(this.name) ? "No Name" : this.name;
        }
    }

    // This is for PassMark property with read only access.

    public int PassMark
    {
        get
        {
            return this.passMark;
        }
    }

    // IMPORTANT NOTE: Auto Implemented Properties : Treated as private fields as above others fields.

    // Instead of writing above get set properties we can write below short syntax also.
    public string City { get; set; }  // City will be treated as "public string city" field with get and set accessors.
    public string Email { get; set; } // Email will be treated as "public string email" field with get and set accessors.

}
class GetSetProperImplementation
{
    public static void RunGetSetProper() // public static void Main()
    {
        CollegeStudent student = new CollegeStudent();
        student.Id = 100;                               // You can directly set the value to "public int Id" property.
        Console.WriteLine(student.Id);                  // You can directly get the value from "public int Id" property.

        student.Name = "John";                          // You can directly set the value to "public string Name" property.
        Console.WriteLine(student.Name);                // You can directly get the value from "public string Name" property.

        //student.PassMark = 40;                        // This line will throw error because "public int PassMark" property is read (get) only.
        Console.WriteLine(student.PassMark);            // You can directly get the value from "public int PassMark" property.

    }
}