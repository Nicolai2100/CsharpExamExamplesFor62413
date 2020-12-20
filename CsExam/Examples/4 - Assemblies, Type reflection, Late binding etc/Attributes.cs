using System;
using System.Runtime.InteropServices;

namespace CsExam.Examples
{
    public class Attributes
    {
        //Først Laver vi en custom attribute.
        //Den bruger selv en attribut til at markere, hvad den må bruges på.
        
        [AttributeUsage(AttributeTargets.Method)  
        ]  
        public class TestAttribute : System.Attribute  
        {  
            private string name;  
      
            public TestAttribute(string name)  
            {  
                this.name = name;  
            }  
        }

        [Obsolete("Use Method2!")]
        public void Method1()
        {
            Console.WriteLine("Hej");
        }

        [Test("Nicolai")]
        public void Method2()
        {
            Beep(1200, 500);
        }
        
        [DllImport("kernel32.dll")] 
        public static extern bool Beep(int frequency, int duration);

        public static void TestMethod()
        {
            Attributes test = new Attributes();

            test.Method1();
            test.Method2();
            
            Type testType = test.GetType();
            var attributes = testType.GetMember("Method2")[0].CustomAttributes;
            
            foreach (var attribute in attributes)
            {
                Console.WriteLine(attribute); //Det fulde navn
                Console.WriteLine(attribute.AttributeType.Name);
                Console.WriteLine(attribute.ConstructorArguments[0]);
            }
        }
    }
}