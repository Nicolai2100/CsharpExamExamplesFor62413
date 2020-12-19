using System;
using System.Reflection;

namespace CsExam.Examples
{
    public class Type_Reflection
    {
        public static void TestMethod()
        {
            //Vi loader et assembly
            Assembly myAssembly = Assembly.LoadFile("/Users/nicolaiwulff/RiderProjects/CsExam/CsExam/bin/Debug/netcoreapp3.1/AssemblyExample.dll");
            
            //Vi finder en type ud fra en string.
            var myType = myAssembly.GetType("AssemblyExample.ClassExample");
            
            //Vi instantierer dynamisk et objekt ud fra denne type.
            dynamic objMyClass = Activator.CreateInstance(myType);
            //Type parameterType = objMyClass.GetType();

            //Vi kan fx printe navnene på alle members af AssemblyExample
            foreach (var memberInfo in myType.GetMembers())
            {
                Console.WriteLine(memberInfo.Name);
            }
            
            //Her invokerer vi en metode fra AssemblyExample klassen. Det sker dynamisk ved runtime.
            var res = myType.InvokeMember("MessageFromAssembly", BindingFlags.InvokeMethod, null, objMyClass, new Object[]{"Nicolai"});
            Console.WriteLine(res);     
        }
    }
}