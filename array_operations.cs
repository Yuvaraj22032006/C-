public class ArrayOperations
{
    // Implement the MultiplyMatrices method
    public static int[][] multiplyMatrices(int[][] matrix1, int[][] matrix2)
    {
        // Write your code here
        if (matrix1 == null || matrix2 == null ||matrix1.Length == 0 || matrix2.Length == 0) {
            return null;
        }

        int rowsA = matrix1.Length;
        int colsA = matrix1[0].Length;
        int rowsB = matrix2.Length;
        int colsB = matrix2[0].Length;

        if (colsA != rowsB) {
            return null;
        }


        // Check if all rows have the same length

        for (int i = 0; i < rowsA; i++) {
            if (matrix1[i].Length != colsA) {
                return null;
            }
        }

        for (int i = 0; i < rowsB; i++) {
            if (matrix2[i].Length != colsB) {
                return null;
            }
        }

        int[][] result = new int[rowsA][];
        for (int i = 0; i < rowsA; i++) {
            result[i] = new int[colsB];
        }

        for (int i = 0; i < rowsA; i++) {
            for (int j = 0; j < colsB; j++) {
                result[i][j] = 0;
                for (int k = 0; k < colsA; k++) {
                    result[i][j] += matrix1[i][k] * matrix2[k][j];
                }
            }
        }

        return result;
        
    }
  public static int[][] AddMatrices(int[][] a, int[][] b)
  {
      int rows = a.Length;
      int[][] result = new int[rows][];
    
      for (int i = 0; i < rows; i++)
      {
          result[i] = new int[a[i].Length];
          for (int j = 0; j < a[i].Length; j++)
          {
              result[i][j] = a[i][j] + b[i][j];
          }
      }
      return result;
  }

  public static int[][] Transpose(int[][] matrix)
  {
      int rows = matrix.Length;
      int cols = matrix[0].Length;
    
      int[][] result = new int[cols][];
      for (int i = 0; i < cols; i++)
      {
          result[i] = new int[rows];
          for (int j = 0; j < rows; j++)
          {
              result[i][j] = matrix[j][i];
          }
      }
      return result;
  }

  int[] RowSums(int[][] matrix)
  {
      int rows = matrix.Length;
      int[] sums = new int[rows];
    
      for (int i = 0; i < rows; i++)
      {
          int sum = 0;
          for (int j = 0; j < matrix[i].Length; j++)
          {
              sum += matrix[i][j];
          }
          sums[i] = sum;
      }
      return sums;
  }
  
}
