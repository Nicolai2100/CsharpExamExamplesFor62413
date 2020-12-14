using System;
using System.Reflection;

namespace Eksamen.Eksempler.Type_Reflection
{
    public class Type_Reflection
    {
        // Properties definition 
        public int RollNo
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        // No Argument Constructor 
        public Type_Reflection()
        {
            RollNo = 0;
            Name = string.Empty;
        }

        // Parameterised Constructor 
        public Type_Reflection(int rno, string n)
        {
            RollNo = rno;
            Name = n;
        }

        // Method to Display Data 
        public void displayData()
        {
            Console.WriteLine("Roll Number : {0}", RollNo);
            Console.WriteLine("Name : {0}", Name);
        }
    }

    class Tester
    {

        //// Main Method 
        //static void Main(string[] args)
        //{
        //    // Declare Instance of class Assembly 
        //    // Call the GetExecutingAssembly method 
        //    // to load the current assembly 
        //    Assembly executing = Assembly.GetExecutingAssembly();

        //    // Array to store types of the assembly 
        //    Type[] types = executing.GetTypes();
        //    foreach (var item in types)
        //    {
        //        // Display each type 
        //        Console.WriteLine("Class : {0}", item.Name);

        //        // Array to store methods 
        //        MethodInfo[] methods = item.GetMethods();
        //        foreach (var method in methods)
        //        {
        //            // Display each method 
        //            Console.WriteLine("--> Method : {0}", method.Name);

        //            // Array to store parameters 
        //            ParameterInfo[] parameters = method.GetParameters();
        //            foreach (var arg in parameters)
        //            {
        //                // Display each parameter 
        //                Console.WriteLine("----> Parameter : {0} Type : {1}",
        //                                        arg.Name, arg.ParameterType);
        //            }
        //        }
        //    }
        //}
    }
}