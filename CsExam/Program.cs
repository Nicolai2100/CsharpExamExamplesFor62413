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
            //PolyMorphTest.TestMethod();
            //GenericArrayExample.TestMethod();
            //Collections.TestMethod();

            //2 - Delegates, Events, LINQ - Language - Integrated Query
            //DelegatesExample.TestMethod();
            //Events.TestMethod();
            //SampleCollection<String>.TestMethod();
            //Events.TestMethod();
            //LINQExample.TestMethod();
            //OperatorOverloading.TestMethod();       

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
            MultiThreads.TestMethod();
            MultiThreads.TestJoin();
            MultiThreads.TestPassingData();
            MultiThreads.TestWithPriority();
            MultiThreads_Locks.TestWithoutLock();
            MultiThreads_Locks.TestWithLock();
            MultiThreads_Locks.TestWithMonitor();
            Tasks.TestMethod();
            Tasks.TestWithAsyncAndAwait();
            Tasks.TestInParallel();

            //6 - LINQ to XML
            //SerializeTest.CreateXmlFile();
            //SerializeTest.ReadSavedXmlFile();
            //XMLToLINQExample.LoadXml();

            //7 - Dynamic Values
            //DynamicExample.TestMethod();



            Console.WriteLine("Press any key to exit");
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
