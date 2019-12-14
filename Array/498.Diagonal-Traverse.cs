/*
498. Diagonal Traverse
Given a matrix of M x N elements (M rows, N columns), return all elements of the matrix in diagonal order as shown in the below image.
Example:

Input:
[
 [ 1, 2, 3 ],
 [ 4, 5, 6 ],
 [ 7, 8, 9 ]
]

Output:  [1,2,4,7,5,3,6,8,9]
*/
public class Solution {
    public int[] FindDiagonalOrder(int[][] matrix) {
        if(matrix == null || matrix.Length == 0 || matrix[0] == null || matrix[0].Length == 0){
            return new int[0];
        }
        int row = 0, col = 0, m = matrix.Length, n = matrix[0].Length;
        int[] output = new int[m * n];
        for(int i = 0; i < output.Length; i++){
            output[i] = matrix[row][col];
            if((row + col) % 2 == 0){ //if row + col is even, always up
                if(col == n - 1){  //last col, go down
                    row++;
                } else if(row == 0){  //first row, not last col, go right;
                    col++;
                } else{ //go up & right
                    row--;
                    col++;
                }
            } else{
                if(row == m - 1){ //last row, go right
                    col++;
                } else if (col == 0){ //first col, go dow
                    row++;
                } else{ //others down left
                    row++;
                    col--;
                }
            }
        }
        return output;
    }
}