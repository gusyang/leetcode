/*
 * @lc app=leetcode id=120 lang=csharp
 *
 * [120] Triangle
 *
 * https://leetcode.com/problems/triangle/description/
 * Testcase Example:  '[[2],[3,4],[6,5,7],[4,1,8,3]]'
 *
 * Given a triangle, find the minimum path sum from top to bottom. Each step
 * you may move to adjacent numbers on the row below.
 * 
 * For example, given the following triangle
 * 
 * 
 * [
 * ⁠    [2],
 * ⁠   [3,4],
 * ⁠  [6,5,7],
 * ⁠ [4,1,8,3]
 * ]
 * 
 * 
 * The minimum path sum from top to bottom is 11 (i.e., 2 + 3 + 5 + 1 = 11).
 * 
 * Note:
 * 
 * Bonus point if you are able to do this using only O(n) extra space, where n
 * is the total number of rows in the triangle.
 * 
 */

// @lc code=start
public class Solution {
        public int MinimumTotal(IList<IList<int>> triangle) {
        if(triangle == null || triangle.Count == 0){
            return 0;
        }
        //init -- in place, do not need init
        //formula -- dp[i][j] = dp[i][j] + Min(dp[i + 1][j], dp[i + 1][j + 1])
        //bottom to top
        //result in top
       for(int i = triangle.Count - 2; i >= 0; i--){
           for(int j = triangle[i].Count - 1; j >= 0; j--){
               triangle[i][j] = Math.Min(triangle[i + 1][j],triangle[i + 1][j + 1]) + triangle[i][j];
           }
       }
       return triangle[0][0];
    }
    public int MinimumTotalRecursion(IList<IList<int>> triangle) {
        if(triangle == null || triangle.Count == 0){
            return 0;
        }
        int size = triangle.Count;
        int[][] memo = new int[size][];
        for(int i = 0; i < size; i++){
            memo[i] = new int[size];
        } 
        return Helper(triangle,0,0,memo);
    }
    private int Helper(IList<IList<int>> triangle, int row, int col, int[][] memo){        
        if(row >= triangle.Count - 1){
            return triangle[row][col];
        }
        int self = triangle[row][col];
        if(memo[row][col] != 0){
            return memo[row][col];
        }
        memo[row][col] = self + Math.Min( Helper(triangle,row + 1, col, memo), Helper(triangle,row + 1, col + 1,memo));
        return memo[row][col];
    }
}
// @lc code=end

