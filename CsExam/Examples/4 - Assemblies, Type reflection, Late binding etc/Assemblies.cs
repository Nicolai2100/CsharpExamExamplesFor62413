using System;
//Namespace peger på den dll
//- Kan gøres efter "”Add Reference” to Library project (Project | Add Reference )"
using AssemblyExample;

namespace CsExam.Examples
{
    public class Assemblies
    {
        public static void TestMethod()
        {
            ClassExample example = new ClassExample();
            Console.WriteLine(example.MessageFromAssembly("Nicolai"));
        }
    }
}