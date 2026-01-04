using System;

public class FindDiagonalDifference
{
    public static int findDiagonalDifference(int[][] matrix)
    {
        // Write your code here
        if (matrix == null || matrix.Length == 0) {
            return -1;
        }

        int n = matrix.Length;

         // Check if it's a square matrix
        for (int i = 0; i < n; i++) {
            if (matrix[i] == null || matrix[i].Length != n) {
                return -1;
            }
        }

        // Calculate the sum of the primary diagonal
        int primarySum = 0;
        for (int i = 0; i < n; i++) {
            primarySum += matrix[i][i];
        }

        int secondarySum = 0;
        for (int i = 0; i < n; i++) {
            secondarySum += matrix[i][n - 1 - i];
        }

        return Math.Abs(primarySum - secondarySum);
    }
}
