using System;

namespace CsExam.Examples
{
    //Enkapsuleret metode
    //must have correct parameters
    //A delegate is a type that holds a reference to a method.A delegate is declared with a signature that shows the 
    //turn type and parameters for the methods it references, and it can hold references 
    //by to methods that match its signature. A delegate is thus equivalent to a type-safe function pointer or a callback. 
    public class DelegatesExample
    {
        public delegate void StrDelegate(string var);

        static string str = "The text is ---> ";

        public static void GetData1(string Name)
        {
            str += "Data_One : " + Name;
        }

        public static void GetData2(string Name)
        {
            str += "Data_Two : " + Name;
        }

        public static void GetData3(string Name)
        {
            str += "Data_Three : " + Name;
        }
        public static string getStr()
        {
            return str;
        }

        public static void TestMethod()
        {
            //create delegate instances
            StrDelegate objMyDelegate = new StrDelegate(GetData1);
            Console.WriteLine("Value of str: {0}", getStr());

            ////GetData1 is called
            objMyDelegate("1 ");
            Console.WriteLine("Value of str: {0}", getStr());

            objMyDelegate += GetData2;
            ////GetData1 + GetData2 is called
            objMyDelegate("2 ");
            Console.WriteLine("Value of str: {0}", getStr());

            objMyDelegate += new StrDelegate(GetData3);
            ////GetData1 + GetData2 + GetData3 is called
            objMyDelegate("3 ");
            Console.WriteLine("Value of str: {0}", getStr());

            objMyDelegate -= GetData2;
            ////GetData1 + GetData3 is called
            objMyDelegate("4 ");
            Console.WriteLine("Value of str: {0}", getStr());

            SomeOtherMethod(objMyDelegate);
        }
        static void SomeOtherMethod(Delegate obj)
        {
            foreach (var method in obj.GetInvocationList())
            {
                Console.WriteLine(method.Method.Name);
            }
            Console.WriteLine(obj.GetInvocationList().Length);
        }
    }
}
