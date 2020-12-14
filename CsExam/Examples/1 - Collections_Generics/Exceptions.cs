using System;
namespace Eksamen.Eksempler.Exception
{
    public class Exceptions
    {

        int result;

        Exceptions()
        {
            result = 0;
        }

        public void division(int num1, int num2)
        {
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }
            finally
            {
                Console.WriteLine("Result: {0}", result);
            }
        }

        //static void Main(string[] args)
        //{
        //    Exceptions d = new Exceptions();
        //    d.division(25, 0);
        //    Console.ReadKey();
        //}
    }
}
