public class ProcessMatrix
{
    public static int[][] processMatrix(int[][] matrix)
    {
        // Write your code here
        if (matrix == null || matrix.Length == 0) {
            return new int[0][];
        }

        int rows = matrix.Length;
        int[][] result = new int[rows][];

        for (int i = 0; i < rows; i++) {
            int cols = matrix[i].Length;
            result[i] = new int[cols];

            for (int j = 0; j < cols; j++) {
                int sum = 0;

                // Check up
                if (i > 0) {
                    sum += matrix[i-1][j];
                }

                //Check down
                if (i < rows-1 && j < matrix[i + 1].Length) {
                    sum += matrix[i + 1][j];
                }

                //Check left
                if (j > 0) {
                    sum += matrix[i][j - 1];
                }

                //Check rigth
                if (j < cols-1) {
                    sum += matrix[i][j + 1];
                }

                result[i][j] = sum;
            }
        }

        return result;
        
    }
}
