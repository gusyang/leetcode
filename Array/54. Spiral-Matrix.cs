/*
Given a matrix of m x n elements (m rows, n columns), return all elements of the matrix in spiral order.
Example 1:
Input:
[
 [ 1, 2, 3 ],
 [ 4, 5, 6 ],
 [ 7, 8, 9 ]
]
Output: [1,2,3,6,9,8,7,4,5]
Example 2:

Input:
[
  [1, 2, 3, 4],
  [5, 6, 7, 8],
  [9,10,11,12]
]
Output: [1,2,3,4,8,12,11,10,9,5,6,7]
 */
public class Solution
{
    public IList<int> SpiralOrder(int[][] matrix)
    {
        IList<int> res = new List<int>();
        if(matrix == null || matrix.Length == 0 || matrix[0].Length == 0) return res;
        int left = 0, top = 0;
        int bottom = matrix.Length - 1, right = matrix[0].Length - 1;

        while( left < right && top < bottom){
            for(int i = left;  i < right; i++) res.Add(matrix[top][i]);
            for(int i = top; i < bottom; i++) res.Add(matrix[i][right]);
            for(int i = right; i > left; i--) res.Add(matrix[bottom][i]);
            for(int i = bottom; i > top; i--) res.Add(matrix[i][left]);
            left++;
            right--;
            top++;
            bottom--;
        }

        //
        if(left == right){
            for(int i = top; i <= bottom; i++) res.Add(matrix[i][left]);
        } else if(top == bottom){
            for(int i = left; i <= right; i++) res.Add(matrix[top][i]);
        }     
        return res;
    }
}