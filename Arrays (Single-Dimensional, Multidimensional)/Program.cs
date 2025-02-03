using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays__Single_Dimensional__Multidimensional_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Single-Dimensional Array
            int[] singleDimensionalArray = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Single-Dimensional Array:");
            for (int i = 0; i < singleDimensionalArray.Length; i++)
            {
                Console.WriteLine($"Element at index {i}: {singleDimensionalArray[i]}");
            }

            // Multidimensional Array (2D Array)
            int[,] multiDimensionalArray = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };
            Console.WriteLine("\nMultidimensional Array (2D Array):");
            for (int i = 0; i < multiDimensionalArray.GetLength(0); i++)
            {
                for (int j = 0; j < multiDimensionalArray.GetLength(1); j++)
                {
                    Console.WriteLine($"Element at index [{i},{j}]: {multiDimensionalArray[i, j]}");
                }
            }

            // Jagged Array
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 2 };
            jaggedArray[1] = new int[] { 3, 4, 5 };
            jaggedArray[2] = new int[] { 6, 7, 8, 9 };
            Console.WriteLine("\nJagged Array:");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.Write($"Row {i}: ");
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write($"{jaggedArray[i][j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
