namespace Top_Interview_Questions.Array_Strings.Spiral_Matrix
{
    public class Spiral_Matrix
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            IList<int> result = new List<int>();

            // This check ensures that the `matrix` object is not `null`. - If `matrix` is `null`, it means there is no 2D array to process, and attempting to access properties or elements of a `null` object will result in a `NullReferenceException`.
            // This check ensures that the `matrix` is not an empty array. - If `matrix.Length == 0`, it means the array has no rows. Therefore, there are no elements to process in spiral order.
            if (matrix == null || matrix.Length == 0) return result;

            int m = matrix.Length;
            int n = matrix[0].Length;

            int left = 0, right = n - 1, top = 0, bottom = m - 1;

            while (left <= right && top <= bottom)
            {
                // Move right
                for (int i = left; i <= right; i++)
                {
                    result.Add(matrix[top][i]);
                }

                top++;

                // Move down
                for (int i = top; i <= bottom; i++)
                {
                    result.Add(matrix[i][right]);
                }

                right--;

                if (top <= bottom)
                {
                    // Move left
                    for (int i = right; i >= left; i--)
                    {
                        result.Add(matrix[bottom][i]);
                    }

                    bottom--;
                }

                if (left <= right)
                {
                    // Move up
                    for (int i = bottom; i >= top; i--)
                    {
                        result.Add(matrix[i][left]);
                    }

                    left++;
                }
            }

            LogList(result);
            return result;
        }

        public static void LogMatrix(int[][] matrix)
        {
            int rows = matrix.Length;
            int cols = matrix[0].Length;

            // Print top border
            Console.WriteLine("+" + new string('-', cols * 4) + "+");

            // Iterate over rows
            for (int i = 0; i < rows; i++)
            {
                // Print row elements with vertical separators
                Console.Write("|");
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(" {0:00} |", matrix[i][j]);
                }

                Console.WriteLine();

                // Print row border
                Console.WriteLine("+" + new string('-', cols * 4) + "+");
            }
        }


        public static void LogList(IList<int> list)
        {
            Console.WriteLine("List Contents: ");
            foreach (int item in list)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }
    }
}