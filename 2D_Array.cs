using System;

class Program
{
    static void Main(string[] args)
    {
        int[][] matrix = {
            // Write your code here
            new int[] {5, 7, 10, 24, 41},
            new int[] {86, 13, 683, 64, 13},
            new int[] {42, 46, 791, 111, 9},
            new int[] {86, 88, 1845, 5, 15897},
            new int[] {9, 1, 5, 5, 6}
        };
        
        // Print the matrix
        int rows = matrix.Length;
        
        for (int i = 0; i < rows; i++)
        {
            int cols = matrix[i].Length;
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}
