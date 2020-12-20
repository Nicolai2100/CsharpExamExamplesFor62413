using System;
using System.Threading;

namespace CsExam.Examples
{
    public class MultiThreads_Locks
    {
        static bool done;
 
        public static void TestWithoutLock()
        {
            Console.WriteLine("\nTest af tråd, der kører samtidig med hovedtråden, uden lock:");
            done = false;
            Thread.Sleep(2000); //For at sikre, at tråden er færdig med at skrive til konsollen.
            
            new Thread (WriteDone).Start();
            WriteDone();
        }
        
        static void WriteDone() 
        {
            if (!done)
            {
                Console.WriteLine ("Done"); //Læg mærke til, "Done" bliver printet to gange! 
                done = true;
            }
        }
        
        static readonly object locker = new object();
        
        static void WriteDoneWithLock() 
        {
            lock (locker) {
                if (!done)
                {
                    Console.WriteLine ("Done"); //Læg mærke til, "Done" bliver printet to gange! 
                    done = true;
                }
            }
        }
        
        public static void TestWithLock()
        {
            Console.WriteLine("\nTest af tråd, der kører samtidig med hovedtråden, MED lock:");
            
            done = false;
            new Thread (WriteDoneWithLock).Start();
            WriteDoneWithLock();
        }
        
        static void WriteDoneWithMonitor()
        {
            Monitor.Enter(locker);
            try
            {
                if (!done)
                {
                    Console.WriteLine ("Done"); //Læg mærke til, "Done" bliver printet to gange! 
                    done = true;
                }
            }
            finally
            {
                Monitor.Exit(locker);
            }
        }

        public static void TestWithMonitor()
        {
            Console.WriteLine("\nTest af tråd, der kører samtidig med hovedtråden, med monitor:");
            
            done = false;
            new Thread(WriteDone).Start();
            WriteDoneWithMonitor();
        }
        
    }
}