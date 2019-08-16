/*
A robot is located at the top-left corner of a m x n grid (marked 'Start' in the diagram below).
The robot can only move either down or right at any point in time. The robot is trying to reach the bottom-right corner of the grid (marked 'Finish' in the diagram below).
Now consider if some obstacles are added to the grids. How many unique paths would there be?

An obstacle and empty space is marked as 1 and 0 respectively in the grid.
Note: m and n will be at most 100.
Example 1:
Input:
[
  [0,0,0],
  [0,1,0],
  [0,0,0]
]
Output: 2
Explanation:
There is one obstacle in the middle of the 3x3 grid above.
There are two ways to reach the bottom-right corner:
1. Right -> Right -> Down -> Down
2. Down -> Down -> Right -> Right
 */
public class Solution
{
    public int UniquePathsWithObstacles1(int[][] obstacleGrid)
    {
        if (obstacleGrid == null || obstacleGrid.Length == 0 || obstacleGrid[0] == null || obstacleGrid[0].Length == 0) return 0;
        int m = obstacleGrid.Length;
        int n = obstacleGrid[0].Length;
        
        obstacleGrid[0][0] ^= 1;          
        //if current is 1 (means can not use this path), so can not access after it, just keep init int(0) 
        for (int i = 1; i < m; i++)
        { 
            obstacleGrid[i][0] =  obstacleGrid[i][0] == 1 ? 0 : obstacleGrid[i - 1][0] ;           
        }
        for (int j = 1; j < n; j++)
        {
            obstacleGrid[0][j] = obstacleGrid[0][j] == 1 ? 0 : obstacleGrid[0][j - 1];
        }

        for (int i = 1; i < m; i++)
        {
            for (int j = 1; j < n; j++)
            {
                obstacleGrid[i][j] = obstacleGrid[i][j] == 1?0:obstacleGrid[i - 1][j] + obstacleGrid[i][j - 1];               
            }
        }
        return obstacleGrid[m - 1][n - 1];
    }

    public int UniquePathsWithObstacles(int[][] obstacleGrid)
    {
        if (obstacleGrid == null || obstacleGrid.Length == 0 || obstacleGrid[0] == null || obstacleGrid[0].Length == 0) return 0;
        int m = obstacleGrid.Length;
        int n = obstacleGrid[0].Length;

        int[][] dp = new int[m][];
        //init 
        for (int i = 0; i < m; i++)
        {
            dp[i] = new int[n];
        }
        //if current is 1 (means can not use this path), so can not access after it, just keep init int(0) 
        for (int i = 0; i < m; i++)
        {
            if (obstacleGrid[i][0] == 1) break;
            dp[i][0] = 1;
        }
        for (int j = 0; j < n; j++)
        {
            if (obstacleGrid[0][j] == 1) break;
            dp[0][j] = 1;
        }

        for (int i = 1; i < m; i++)
        {
            for (int j = 1; j < n; j++)
            {
                if (obstacleGrid[i][j] == 1) continue;
                dp[i][j] = dp[i - 1][j] + dp[i][j - 1];
            }
        }
        return dp[m - 1][n - 1];
    }
}