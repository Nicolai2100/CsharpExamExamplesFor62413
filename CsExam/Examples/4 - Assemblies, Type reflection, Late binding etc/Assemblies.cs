using System;
//Namespace peger p� den dll
//- Kan g�res efter "�Add Reference� to Library project (Project | Add Reference )"
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