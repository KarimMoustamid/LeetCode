namespace Top_Interview_Questions.Array_Strings.Game_of_Life
{
    public class GameOfLife
    {
        public void NextStage(int[][] board)
        {
            int m = board.Length;
            int n = board[0].Length;

            // Directions to check the 8 neighbors of each cell
            int[] dx = {-1, -1, -1, 0, 0, 1, 1, 1};
            int[] dy = {-1, 0, 1, -1, 1, -1, 0, 1};

            // First pass: mark the cells with temporary states
            for (int row = 0; row < m; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    int liveNeighbors = 0;

                    // Count live neighbours foreach cell
                    for (int k = 0; k < 8; k++)
                    {
                        int x = row + dx[k];
                        int y = col + dx[k];

                        if (x >= 0 && x < m && y >= 0 && y < n && (board[x][y] == 1 || board[x][y] == 2))
                        {
                            liveNeighbors++;
                        }
                    }
                }
            }
            // Apply the rules
        }
    }
}