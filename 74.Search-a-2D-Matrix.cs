using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode
{
    public static class _74_2DMatrix
    {
        /*
         Write an efficient algorithm that searches for a value in an m x n matrix. This matrix has the following properties:
        Integers in each row are sorted from left to right.
        The first integer of each row is greater than the last integer of the previous row.
        Example 1:

        Input:
        matrix = [
          [1,   3,  5,  7],
          [10, 11, 16, 20],
          [23, 30, 34, 50]
        ]
        target = 3
        Output: true
        Example 2:

        Input:
        matrix = [
          [1,   3,  5,  7],
          [10, 11, 16, 20],
          [23, 30, 34, 50]
        ]
        target = 13
        Output: false
         * */
        public static bool SearchMatrix(int[][] matrix, int target)
        {
            if (matrix == null || matrix.Length == 0 || matrix[0] == null || matrix[0].Length == 0)
            {
                return false;
            }
            /*
            for sorted array, use binary search twice
            1. find targe row
            2. find targe value
             */

            int m = matrix.Length, n = matrix[0].Length;
            int startRow = 0, endRow = m - 1;
            int targetRow = 0;
            // find row, start with Row + 1, otherwise, may not jump out this loop
            while (startRow + 1 < endRow)
            {
                //find mid value
                int mid = startRow + (endRow - startRow) / 2;
                //if targe < mid, target in left side, move end to mid
                if (matrix[mid][n - 1] > target)
                {
                    endRow = mid;
                }
                else if (matrix[mid][n - 1] < target) // target > mid, in right side, move start to mid
                {
                    startRow = mid;
                }
                else
                {
                    return true; //target = mid, find.
                }
            }
            if (matrix[startRow][n - 1] >= target)
            {
                targetRow = startRow;
            }
            else if (matrix[endRow][n - 1] >= target)
            {
                targetRow = endRow;
            }
            else
            {
                return false;
            }

            //find col
            int startCol = 0, endCol = n - 1;
            while (startCol + 1 < endCol)
            {
                int mid = startCol + (endCol - startCol) / 2;
                if (matrix[targetRow][mid] < target)
                {
                    startCol = mid;
                }
                else
                {
                    endCol = mid;
                }
            }
            if (matrix[targetRow][startCol] == target || matrix[targetRow][endCol] == target)
            {
                return true;
            }
            return false;
        }
    }
}
