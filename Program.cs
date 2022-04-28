using System;

namespace DataStructuresAndAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Multidimensional array's length will multiple the dimensions
            int[,] multiArray = new int[2, 3];
            int multiArrValue = multiArray[0, 2];

            Console.WriteLine(multiArray.Length);

            //Jagged arra's length is just the number of columns
            int[][] jagArray = new int[2][];
            jagArray[0] = new int[3];

            Console.WriteLine(jagArray.Length);


        }
    }
}
