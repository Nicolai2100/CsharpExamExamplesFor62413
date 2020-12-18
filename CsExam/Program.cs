using CsExam.Examples;
using System;

namespace CsExam
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - Collections, Generics, Exceptions, Interfaces

            //2 - Delegates, Events, LINQ - Language - Integrated Query
            //DelegatesExample.testings();
            //Events.TestMethod();


            //5 - Assemblies
            Assemblies.TestMethod(); //Prints out a message, that is generated from a AssemblyExample.dll
            Type_Reflection2.TestMethod();
            LateBinding.TestMethod();

            //6 - LINQ to XML
            //SerializeTest.TestExample();
            //var xml = new XmlExample();
            //xml.loadXml();
            //XmlExample.XMLTree();
            //XmlExample.instaElements();
            //var xmlReader = new XmlExample();

            //Console.WriteLine("Hello World!");
        }
    }
}
