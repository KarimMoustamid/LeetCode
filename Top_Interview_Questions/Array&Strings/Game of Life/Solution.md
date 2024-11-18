# Conway's Game of Life: Solution Explanation

## Problem Recap
The problem asks us to update a grid (`board`) of cells where:
- Each cell is either alive (`1`) or dead (`0`).
- The next state of each cell depends on its **8 neighbors** (up, down, left, right, and diagonals).
- **Rules**:
    1. Any live cell (`1`) with fewer than 2 live neighbors dies (underpopulation).
    2. Any live cell (`1`) with 2 or 3 live neighbors lives (survival).
    3. Any live cell (`1`) with more than 3 live neighbors dies (overpopulation).
    4. Any dead cell (`0`) with exactly 3 live neighbors becomes alive (reproduction).

## Key Constraints
- **Simultaneous Updates**: All cells must be updated simultaneously. This means you can't update one cell and immediately use its new value to calculate the next state of another.
- **In-Place Requirement**: The solution must not use extra space.

---

## Solution Logic

### Step 1: Mark Intermediate States
To meet the in-place requirement, we cannot immediately flip `1` to `0` or `0` to `1` because that would interfere with neighbor calculations. Instead, we use intermediate states:
- **`2`**: Represents a cell that is alive (`1`) in the current state but will die in the next state.
- **`-1`**: Represents a cell that is dead (`0`) in the current state but will become alive in the next state.

This allows us to:
1. Count the neighbors based only on the original states (`0` or `1`).
2. Safely update the board while preserving the original state information for neighbor counting.

---

### Step 2: Neighbor Counting
For each cell in the grid, we count how many of its 8 neighbors are alive. Since the board has boundaries, we carefully check that neighbor indices are within bounds (`0 <= x < m` and `0 <= y < n`).

- Directions to check neighbors are represented as two arrays:
  ```csharp
  int[] dx = {-1, -1, -1, 0, 0, 1, 1, 1};
  int[] dy = {-1,  0,  1, -1, 1, -1, 0, 1};

## Neighbor Directions in a 2D Grid

When working with a 2D grid, each cell can potentially have 8 neighbors (assuming it is not on the edge or corner). These neighbors are positioned relative to the current cell as follows:

- Top-left
- Top-center
- Top-right
- Center-left
- Center-right
- Bottom-left
- Bottom-center
- Bottom-right

To navigate these 8 directions, we can use `dx` and `dy` arrays.

### Direction Arrays

In the code, `dx` and `dy` arrays help in computing the coordinates of the neighboring cells. Each index in `dx` corresponds to an index in `dy`, defining the relative position of a neighbor.

```csharp
// Directions to check the 8 neighbors of each cell
/*
 dx[i]  dy[i]   Relative Position
 -----  -----   -----------------
 -1     -1      Top-left
 -1      0      Top-center
 -1     +1      Top-right
  0     -1      Center-left
  0     +1      Center-right
 +1     -1      Bottom-left
 +1      0      Bottom-center
 +1     +1      Bottom-right
*/
```

### Using the Direction Arrays

Consider a cell at position `(row, col)` in the grid. To get the coordinates of its neighbors, we add the respective `dx` and `dy` values to the coordinates of the current cell:

For the neighbor at index `k`:
```csharp
int r = row + dx[k];
int c = col + dy[k];
```

### Example

Here's a practical example in a loop that checks all 8 neighbors:

```csharp
for (int k = 0; k < 8; k++)
{
    int r = row + dx[k];
    int c = col + dy[k];

    if (r >= 0 && r < m && c >= 0 && c < n && Math.Abs(board[r][c]) == 1)
    {
        liveNeighbours++;
    }
}
```

This loop ensures that we are considering all 8 possible neighbors of each cell, while correctly handling edge and corner cases by checking the bounds of the grid.