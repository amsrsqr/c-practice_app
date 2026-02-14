using System;
using System.Text; // StringBuilder is exist in that import.
// Difference between System.String and System.Text.StringBuilder  
// System.String is Immutable (Non-Editable)
// System.Text.StringBuilder is mutable (Editable)
// We have better performance using stringBuilder
namespace Amol
{
    public class differenceStringAndStringBuilder
    {
        public static void RunStringAndStringBuilder()
        {
//--------------------------------------------------------------------- Using System.String

            string userName = "c#";
            userName += "video";
            userName += "is";
            userName += "friendly";
            userName += "beginners";
            // So what happen here about System.String
            // userName will created on STACK
            // and it's value like c#, video, is, friendly will get created seperately in HEAP 
            // like first "c#" then "c# video" then "c# video is" then  "c# video is friendly" then finally "c# video is friendly beginners"
            // so here 5 object will get created 
            // 4 will be unused that would be grabage collected why because of 3rd point.
            // last one will be used.

            Console.WriteLine(userName);
//---------------------------------------------------------------------- Using System.Text.StringBuilder  

            //IMPORTANT
            // string builder will get created only one object which will be editable as per requirments. SO it is mutable

            StringBuilder stringBuilder = new StringBuilder("c#");
            stringBuilder.Append("video");   // Instead of + we will use Append() method here.
            stringBuilder.Append("is");
            stringBuilder.Append("friendly");
            stringBuilder.Append("beginners");
            Console.WriteLine(userName.ToString()); //  To print this output.
                                                    //the primary reason to use the ToString() method with a StringBuilder is to explicitly convert the mutable StringBuilder object into an immutable String object

 //---------------------------------------------------------------------- What if we use System.String

            // Suppose we have this program
            // In this program when use heavy string manupulation involved then we will use StringBuilder().

            string userString = string.Empty;

            for (int i = 0; i < 1000; i++) {
                userString += i.ToString() + " ";
            }
            Console.WriteLine(userString);

        }
    }

    public class StringCustomer
    {
        public string CustomerName { get; set; }
    }

}
