using System;
using System.Threading;

namespace CsExam.Examples
{
    public class MultiThreads
    {
        
        public static void Method1() 
        {
            // Printer tallene fra 1 til 10
            for (int I = 0; I <= 10; I++) { 
                Console.WriteLine("Method1 : {0}, Tråd: {1}", I, Thread.CurrentThread.Name);
            } 
        } 
  
        // static method two 
        public static void Method2() 
        { 
            // Printer tallene fra 1 til 10
            for (int J = 0; J <= 10; J++) { 
                Console.WriteLine("Method2 : {0}, Tråd: {1}", J, Thread.CurrentThread.Name); 
            }
        }

        public static void Method3(String msg)
        {
            Console.WriteLine(msg);
        }

        public static void TestMethod()
        {
            Thread thr1 = new Thread(Method1); 
            Thread thr2 = new Thread(Method2);
            thr1.Name = "Metode 1 tråd";
            thr2.Name = "Metrod 2 tråd";
            thr1.Start(); 
            thr2.Start(); 
        }
        
        public static void TestJoin()
        {
            Thread t = new Thread(Method1);
            t.Start();
            t.Join();
            Console.WriteLine("Tråden t er nu færdig!");
        }

        public static void TestPassingData()
        {
            Thread t = new Thread(() => Method3("Denne besked er passed til Message3"));
            t.Start();
        }
        
        public static void TestWithPriority()
        {
            Thread thr1 = new Thread(Method1); 
            Thread thr2 = new Thread(Method2);
            thr1.Name = "Metode 1 tråd";
            thr2.Name = "Metrod 2 tråd";
            thr1.Priority = ThreadPriority.Highest;
            thr2.Priority = ThreadPriority.Lowest;
            thr1.Start(); 
            thr2.Start(); 
        }
    }
}