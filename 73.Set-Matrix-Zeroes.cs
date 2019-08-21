/*
Given a m x n matrix, if an element is 0, set its entire row and column to 0. Do it in-place.
Example 1:
Input: 
[
  [1,1,1],
  [1,0,1],
  [1,1,1]
]
Output: 
[
  [1,0,1],
  [0,0,0],
  [1,0,1]
]
 */
 public class Solution {
    public void SetZeroes(int[][] matrix) {
         if(matrix == null || matrix.Length == 0 || matrix[0] == null || matrix[0].Length == 0)  return;
        bool firstRow = false, firstCol = false;
        for(int i = 0; i < matrix.Length; i++) {
            for(int j = 0; j < matrix[0].Length; j++) {
                if(matrix[i][j] == 0) {
                    if(i == 0) firstRow = true;
                    if(j == 0) firstCol = true;
                    matrix[0][j] = 0;
                    matrix[i][0] = 0;
                }
            }
        }
        for(int i = 1; i < matrix.Length; i++) {
            for(int j = 1; j < matrix[0].Length; j++) {
                if(matrix[i][0] == 0 || matrix[0][j] == 0) {
                    matrix[i][j] = 0;
                }
            }
        }
        if(firstRow) {
            for(int j = 0; j < matrix[0].Length; j++) {
                matrix[0][j] = 0;
            }
        }
        if(firstCol) {
            for(int i = 0; i < matrix.Length; i++) {
                matrix[i][0] = 0;
            }
        }    
    }
}