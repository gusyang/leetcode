/**
Given a positive integer n, generate a square matrix filled with elements from 1 to n2 in spiral order.
Example:
Input: 3
Output:
[
 [ 1, 2, 3 ],
 [ 8, 9, 4 ],
 [ 7, 6, 5 ]
]
 */
public class Solution
{
    public int[][] GenerateMatrix(int n)
    {
        int left = 0, right = n - 1, bottom = n - 1, top = 0; 
        int num = 1;
        int[][] result = new int[n][];
        //init
        for(int i = 0; i < n; i++){
            result[i] = new int[n];
        }

        while(left < right && top < bottom){
            // left -> right
            for(int i = left; i < right; i++){
                result[top][i] = num++;
            }
            //top -> bottom
            for(int i = top; i < bottom; i++){
                result[i][right] = num++;
            }
            //right -> left
            for(int i = right; i > left; i --){
                result[bottom][i] = num++;
            }
            //bottom -> top
            for(int i = bottom; i > top; i--){
                result[i][left] = num++;
            }
            left++;
            right--;
            top++;
            bottom--;
        }
        if(n % 2 == 1) {
            result[n/2][n/2] = num;
        }
        return result;
    }
}