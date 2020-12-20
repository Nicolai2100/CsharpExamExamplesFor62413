using System;
using System.Collections.Generic;

namespace CsExam.Examples
{
    public class PolyMorphTest
    {
        public static void TestMethod()
        {
            var workers = new List<IWorker>();
            var slave = new Slave();
            var boss = new Boss();
            workers.Add(slave);
            workers.Add(boss);

            foreach (var worker in workers)
            {
                Console.WriteLine(worker.CelebrateWeekend());
                Console.WriteLine(worker.GetSalary());
            }
        }

        public class Slave : IWorker
        {
            public string CelebrateWeekend()
            {
                return "Drink beer";
            }

            public double GetSalary()
            {
                return 10000.00;
            }
        }

        public class Boss : IWorker
        {
            public string CelebrateWeekend()
            {
                return "Drink champagne!";
            }

            public double GetSalary()
            {
                return 1000000.00;
            }
        }
    }
}
