using System;
namespace CsExam.Examples
{
    public class DynamicExample
    {
        static void PrintValue(dynamic val)
        {
            Console.WriteLine(val);
        }

        public static void TestMethod()
        {
            PrintValue("Hello World!!");
            PrintValue(100);
            PrintValue(100.50);
            PrintValue(true);
            PrintValue(DateTime.Now);
        }
    }
}
