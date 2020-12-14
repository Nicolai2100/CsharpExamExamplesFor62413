using System;
namespace Eksamen.Eksempler.Events
{
    public class Events
    {
        public delegate string MyDel(string str);

        event MyDel MyEvent;
        event MyDel MyHello;

        public Events()
        {
            MyEvent += new MyDel(WelcomeUser);
            MyHello += new MyDel(WelcomeUser);
        }
        public string WelcomeUser(string username)
        {
            return "Welcome " + username;
        }
        //static void Main(string[] args)
        //{
        //    Events obj1 = new Events();
        //    Events obj2 = new Events();
        //    string result = obj1.MyEvent("Sersan");
        //    string result1 = obj2.MyHello("Aslan");
        //    Console.WriteLine(result);
        //    Console.WriteLine(result1);
        //}
    }

}
