// See https://aka.ms/new-console-template for more information
using Top_Interview_Questions.Array_Strings.Game_of_Life;

int m = 3;
int n = 3;

int[][] board =
{
    new int[] {1, 2, 3},
    new int[] {4, 5, 6},
    new int[] {7, 8, 9}
};

GameOfLife solution = new GameOfLife();

solution.NextStage(board);