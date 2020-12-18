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
            //GenericArrayExample.TestMethod();
            //Collections.TestMethod();
            //2 - Delegates, Events, LINQ - Language - Integrated Query
            //DelegatesExample.testings();
            //Events.TestMethod();
            //SampleCollection<String>.TestMethod();
            //Events.TestMethod();
            //LINQExample.TestMethod();
            //OperatorOverloading.TestMethod();       

            //5 - Assemblies
            //Assemblies.TestMethod(); //Prints out a message, that is generated from a AssemblyExample.dll
            //Type_Reflection2.TestMethod();
            //LateBinding.TestMethod();
            //Attributes.TestMethod();

            //6 - LINQ to XML
            SerializeTest.CreateXmlFile();
            SerializeTest.ReadSavedXmlFile();

            //XMLToLINQExample.LoadXml();
           
            //7 - Dynamic Values
            //DynamicExample.TestMethod();

        }
    }
}
