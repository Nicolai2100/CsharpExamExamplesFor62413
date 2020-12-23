using System;
using System.IO;
using System.Linq;
using System.Reflection;
//Reflection is to find information about an assembly on run-time
namespace CsExam.Examples
{
    public class TypeReflection
    {
        public static void TestMethod()
        {
            string path = Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).FullName;
            Console.WriteLine("Loading assembly from path: " + path);
            Assembly myAssembly = Assembly.LoadFile(path + "\\AssemblyExample.dll");

            var myType = myAssembly.GetType("AssemblyExample.ClassExample");
            //LateBinding
            dynamic objMyClass = Activator.CreateInstance(myType);
            Type parameterType = objMyClass.GetType();

            //Vi kan fx printe navnene på alle members af AssemblyExample

            foreach (var memberInfo in parameterType.GetMembers())
            {
                Console.WriteLine("Member Name: {0}", memberInfo.Name);
            }

            Console.WriteLine("***** Methods *****");
            var loadedMethods = from n in parameterType.GetMethods()
                                select n;
            foreach (var meth in loadedMethods)
            {
                Console.WriteLine("-> Member Name: {0}", meth.Name);
                Console.WriteLine("-> Member DeclaringType: {0}", meth.DeclaringType);
                Console.WriteLine("-> Member Module: {0}", meth.Module);
                Console.WriteLine("-> Member MemberType: {0}", meth.MemberType);
                Console.WriteLine("-> Member MetadataToken: {0}", meth);
            }

            Console.WriteLine("***** AssemlyExample Methods *****");
            var loadedMethods2 = from n in parameterType.GetMethods()
                                 where !(n.DeclaringType.ToString().Equals("System.Object"))
                                 select n;

            Console.WriteLine("Running method from the AssemblyExample-class");

            foreach (var method in loadedMethods2)
            {
                Console.WriteLine(method.Invoke(objMyClass, new Object[] { "Nicolai" }));
            }

            //Her invokerer vi en metode fra AssemblyExample klassen. Det sker dynamisk ved runtime.
            var res = parameterType.InvokeMember("MessageFromAssembly", BindingFlags.InvokeMethod, null, objMyClass, new Object[] { "Nicolai" });
            Console.WriteLine(res);

            var ctors = parameterType.GetConstructors();
            var ctor = (ctors[0]);
           
        }
    }
}