using System;

namespace c_oop_practice_pen_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Pen myPen = new Pen();  //Object of Pen class. Checking various character counts and check the ink levels.

            myPen.Write();
            myPen.Write("ShailzaSharma");
            myPen.Write("HiShailzaSharma");
            myPen.Write("HelloShailzaSharma");

            //Please uncomment the code below to check that will throw the exception: "Not enough ink level! Cannot print..."
            // myPen.Write("C# is a simple & powerful object-oriented programming language developed by Microsoft. C# can be used to create various types of applications, such as web, windows, console applications, or other types of applications using Visual studio.These C# tutorials will help you learn the essentials of C#, from the basic to advance level topics. These tutorials are broken down into sections, where each section contains a number of related topics that are packed with easy to understand explanations, real-world examples, useful tips, informative notes and a points to remember section.");

        }
    }
}
