using System;
namespace CsExam.Examples
{
    public class LateBinding
    {
        public static void TestMethod()
        {
            Dynamicy objects;
            dynamic obj = 4;
            dynamic obj1 = 5.678;

            //Display the type of objects
            Console.WriteLine("The type of the objects are :");

            //GetType() method is
            //used to get the type
            Console.WriteLine(obj.GetType());
            Console.WriteLine(obj1.GetType());
        }
    }
}