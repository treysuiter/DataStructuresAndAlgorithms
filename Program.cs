using System;
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

            static void StringTest()
            {
                string stringA = "what";
                string stringB = "what";

                Console.WriteLine(Object.ReferenceEquals(stringA, stringB).ToString());  
            }
            StringTest();
        }
    }
}
