using CsExam.Examples;
using System;
using System.IO;

namespace CsExam
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - Collections, Generics, Exceptions, Interfaces

            //ExceptionExample.TestMethod();
            //Console.WriteLine("------------------------------------------------------");
            //PolyMorphTest.TestMethod();
            //Console.WriteLine("------------------------------------------------------");
            //GenericArrayExample.TestMethod();
            //Console.WriteLine("------------------------------------------------------");
            //Collections.TestMethod();

            //2 - Delegates, Events, LINQ - Language - Integrated Query
            DelegatesExample.TestMethod();
            Console.WriteLine("------------------------------------------------------");
            Events.TestMethod();
            Console.WriteLine("------------------------------------------------------");
            SampleCollection<String>.TestMethod();
            Console.WriteLine("------------------------------------------------------");
            Events.TestMethod();
            Console.WriteLine("------------------------------------------------------");
            LINQExample.TestMethod();
            Console.WriteLine("------------------------------------------------------");
            OperatorOverloading.TestMethod();

            //4 - Assemblies, Type reflection, Late binding, and Attribute Programming
            //Assemblies.TestMethod(); //Prints out a message, that is generated from a AssemblyExample.dll
            //Console.WriteLine("------------------------------------------------------");
            //TypeReflection.TestMethod();
            //Console.WriteLine("------------------------------------------------------");
            //LateBinding.TestMethod();
            //Console.WriteLine("------------------------------------------------------");
            //Attributes.TestMethod();
            //Console.WriteLine("------------------------------------------------------");

            //5 – AppDomains, Multi-threads and parallel programming
            //Console.WriteLine("MultiThreads-----------------------------------------");
            //MultiThreads.TestMethod();
            //Console.WriteLine("------------------------------------------------------");
            //MultiThreads.TestUdenJoin();
            //Console.WriteLine("------------------------------------------------------");
            //MultiThreads.TestMedJoin();
            //Console.WriteLine("------------------------------------------------------");
            //MultiThreads.TestPassingData();
            //Console.WriteLine("------------------------------------------------------");
            //MultiThreads.TestWithPriority();    
            //Console.WriteLine("MultiThreadsLocks--------------------------------------");

            //MultiThreadsLocks.TestWithoutLock();
            //MultiThreadsLocks.TestWithLock();
            //MultiThreadsLocks.TestWithMonitor();

            //Tasks.TestMethod();
            //Console.WriteLine("------------------------------------------------------");
            //Tasks.TestWithAsyncAndAwait();
            //Console.WriteLine("------------------------------------------------------");
            //Tasks.TestInParallel();

            ////6 - LINQ to XML
            //SerializeTest.CreateXmlFile();
            //Console.WriteLine("------------------------------------------------------");

            //SerializeTest.ReadSavedXmlFile();
            //Console.WriteLine("------------------------------------------------------");

            //XMLToLINQExample.LoadXml();
            //Console.WriteLine("------------------------------------------------------");

            //XMLToLINQExample.XMLTree();
            //Console.WriteLine("------------------------------------------------------");

            //7 - Dynamic Values
            //DynamicTypesExample.TestMethod();

            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();
        }

        struct Komponent
        {
            public string type;
            public string navn;
            public Komponent(string t, string n)
            {
                type = t;
                navn = n;
            }
        }
    }
}
