using System;
namespace CsExam.Examples
{
    //Advanced type contruction
    public class Indexers
    {
        private string[] strArr = new string[10]; // internal data storage

        // Indexer method
        public string this[int index]
        {
            get
            {
                if (index < 0 && index >= strArr.Length)
                    throw new IndexOutOfRangeException("Index out of range");

                return strArr[index];
            }

            set
            {
                if (index < 0 || index >= strArr.Length)
                    throw new IndexOutOfRangeException("Index out of range");

                strArr[index] = value;
            }
        }

        //public static void Main(string[] args)
        //{
        //    Indexers strStore = new Indexers();

        //    strStore[0] = "One";
        //    strStore[1] = "Two";
        //    strStore[2] = "Three";
        //    strStore[3] = "Four";

        //    for (int i = 0; i < 10; i++)
        //        Console.WriteLine(strStore[i]);
        //}
    }
}
