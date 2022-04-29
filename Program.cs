using System;
using System.Linq;
using System.Text;
using BenchmarkDotNet;

namespace DataStructuresAndAlgorithms
{
    internal class Program
    {
        static void Main()
        {
            //static void ArrayTest()
            //{
            //    int[] array = new int[] { 1, 2, 3 };
            //    Array.ForEach(array, Console.WriteLine);
            //}
            //ArrayTest();

            //static void StringTest()
            //{
            //    string stringA = "what";
            //    string stringB = "what";

            //    Console.WriteLine(Object.ReferenceEquals(stringA, stringB).ToString());  
            //}
            //StringTest();

            var sb = new StringBuilder();
            foreach (int i in Enumerable.Range(1, 10))
            {
                sb.Append(i);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
