// See https://aka.ms/new-console-template for more information

using Top_Interview_Questions.Array_Strings.Spiral_Matrix;
int[][] matrix1 = new int[][]
{
    new int[] {1, 2, 3},
    new int[] {4, 5, 6},
    new int[] {7, 8, 9}
};

int[][] matrix2 = new int[][]
{
    new int[] {1, 2, 3, 4},
    new int[] {5, 6, 7, 8},
    new int[] {9, 10, 11, 12}
};

Spiral_Matrix solution = new Spiral_Matrix();
Spiral_Matrix.LogMatrix(matrix1);
solution.SpiralOrder(matrix1);
Console.WriteLine("");
Spiral_Matrix.LogMatrix(matrix2);
solution.SpiralOrder(matrix2);