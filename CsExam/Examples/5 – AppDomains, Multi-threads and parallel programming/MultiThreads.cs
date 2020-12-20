using System;
using System.Diagnostics;
using System.Threading;

namespace CsExam.Examples
{
    public class MultiThreads
    {
        public static void Method1() 
        {
            // Printer tallene fra 1 til 10
            for (int i = 0; i <= 100000; i++) {
                if ((i % 10000) == 0)
                {
                    Console.WriteLine("Method1 : {0}, Tråd: {1}", i, Thread.CurrentThread.Name);
                }
            }
        } 
  
        public static void Method2() 
        { 
           for (int i = 0; i <= 100000; i++) {
                if ((i % 10000) == 0)
                {
                    Console.WriteLine("Method2 : {0}, Tråd: {1}", i, Thread.CurrentThread.Name);
                }
            } 
        }

        public static void Method3(String msg)
        {
            Console.WriteLine(msg);
        }

        public static void TestMethod()
        {
            Console.WriteLine("\nTest af to tråde, der samtidig printer tal 1-10:");
            Thread thr1 = new Thread(Method1); 
            Thread thr2 = new Thread(Method2);
            thr1.Name = "Metode 1 tråd";
            thr2.Name = "Metode 2 tråd";

            thr1.Start(); 
            thr2.Start(); 
        }
        public static void TestUdenJoin()
        {
            Console.WriteLine("\nTest af tråd, som der kaldes join på:");
            Thread t = new Thread(Method1);
            t.Start();
            //Hovedtråd venter IKKE på at "t" er færdig.
            Console.WriteLine("Tråden t er nu færdig!");
        }

        public static void TestMedJoin()
        {
            Console.WriteLine("\nTest af tråd, som der kaldes join på:");
            Thread t = new Thread(Method2);
            t.Start();
            t.Join();
            //Hovedtråd venter på at "t" er færdig.
            Console.WriteLine("Tråden t er nu færdig!");
        }

        public static void TestPassingData()
        {
            Console.WriteLine("\nTest af tråd, hvor der passes en string til metoden:");
            
            Thread t = new Thread(() => Method3("Denne besked er passed til Message3"));
            t.Start();
        }
        
        public static void TestWithPriority()
        {
            Console.WriteLine("\nTest af to tråde med høj og lav prioritet:");
            
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