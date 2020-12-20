using System;
namespace CsExam.Examples
{
    //.NET exception handling has four elements
    //A type representing an exception(an Exception class)
    //A method that throws an exception(throw keyword)
    //A block of code which invoke an exception(try section)
    //A block of code which handles the exception(catch section)

    //If an exception is thrown in the built-in classes’ methods
    //A System exception is thrown
    //System.Exception inherit from Exception
    //Exceptions are thrown by CLR

    public class ExceptionExample
    {
        int result;

        ExceptionExample()
        {
            result = 0;
        }
        public void FaultyDivision(int num1, int num2)
        {
            try
            {
                result = num1 / num2;
                if (result <= num1)
                {
                    throw new MyOwnException("Resultatet er for lavt!");
                }
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
                Console.WriteLine("User error: {0}", e.Message);
                Console.WriteLine("From: {0}", e.Source);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught: {0}", e.Message);
                Console.WriteLine("From: {0}", e.Source);
            }
            //finally – will always be executed
            finally
            {
                Console.WriteLine("Result: {0}", result);
            }
        }
        public static void TestMethod()
        {
            var d = new ExceptionExample();
            d.FaultyDivision(25, 0);
            d.FaultyDivision(25, 1);
            Console.ReadKey();

        }

        public class MyOwnException : Exception
        {
            private string msg;
            private string _userMsg;
            public MyOwnException(string userMsg)
            {
                _userMsg = userMsg;
            }
            public override string Message
            {
                get
                {
                    msg = base.Message;
                    msg += "User Message: " + _userMsg;
                    return msg;
                }
            }
        }
    }
}
