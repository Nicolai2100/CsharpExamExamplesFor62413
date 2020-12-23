using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace CsExam.Examples
{
    public class Tasks
    {
        private static readonly HttpClient _httpClient = new HttpClient();

        public static void TestMethod()
        {
            Console.WriteLine("\nTest med en task og status på task:");

            Task<int> t = new Task<int>(() =>
            {
                Thread.Sleep(3000); //Man bør ikke bruge Thread.Sleep på tasks. I stedet Task.Delay
                var html = _httpClient.GetStringAsync("https://dotnetfoundation.org");
                return Regex.Matches(html.Result, @"\.NET").Count;
            });
            
            Console.WriteLine(t.Status);
            t.Start();
            Console.WriteLine(t.Status);
            Thread.Sleep(1000);
            Console.WriteLine(t.Status);
            Console.WriteLine(t.Result); //Venter på, den er færdig
            Console.WriteLine(t.Status);
            Console.WriteLine("Returnerer fra metoden");
        }
        
        public static async Task<int> GetDotNetCount()
        {
            var html = await _httpClient.GetStringAsync("https://dotnetfoundation.org");
            return Regex.Matches(html, @".NET").Count;
        }
        public static async Task<int> GetPCount()
        {
            var html = await _httpClient.GetStringAsync("https://dotnetfoundation.org");
            return Regex.Matches(html, @".").Count;
        }

        public static void TestWithAsyncAndAwait()
        {
            Console.WriteLine("\nTest med async og await:");
            
            Task<int> t = GetDotNetCount();
            Console.WriteLine(t.Status);
            //Dette får tråden til at vente på, at tasken er færdig, så den kan returne en værdi.
            var res = t; 
            Console.WriteLine(t.Status);
            Console.WriteLine(res);
            Console.WriteLine("Returnerer fra metoden");
        }

        public static void TestInParallel()
        {
            Console.WriteLine("\nTest af paralelle tasks:");
            
            var task1 = GetDotNetCount();
            //var task2 = GetDotNetCount();
            var task2 = GetPCount();
            //Kører de to tasks parallelt
            var parallelTask = Task.WhenAll(task1, task2); 
            var res = parallelTask.Result;
            Console.WriteLine(res[0]);
            Console.WriteLine(res[1]);
            Console.WriteLine("Returnerer fra metoden");

        }
    }
}