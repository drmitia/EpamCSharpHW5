using System;

namespace epamHW5_ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            int length = Convert.ToInt32(Console.ReadLine());
            int width = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[width, length];
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

                
            Change2DArray(array);
            Print2DArray(array);
        }
        static void Change2DArray(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            int[] lastRow = new int[cols];
            for (int j = 0; j < cols; j++)
            {
                lastRow[j] = array[rows - 1, j];
            }
            for (int i = rows - 1; i > 0; i--)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = array[i - 1, j];
                }
            }
            for (int j = 0; j < cols; j++)
            {
                array[0, j] = lastRow[j];
            }
        }
        static void Print2DArray(int[,] array)
        {
            int length = array.GetLength(0);
            int width = array.GetLength(1);

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
            }
        }
    }
}