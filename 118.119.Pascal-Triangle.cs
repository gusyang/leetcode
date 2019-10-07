
using System;
using System.Collections.Generic;

namespace myapp
{
    public class PascalTriangle{
        /*
        118. Pascal's Triangle
        Given a non-negative integer numRows, generate the first numRows of Pascal's triangle.
        In Pascal's triangle, each number is the sum of the two numbers directly above it.
        Example:

        Input: 5
        Output:
        [
            [1],
            [1,1],
            [1,2,1],
            [1,3,3,1],
            [1,4,6,4,1]
        ]
        */
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> res = new List<IList<int>>();
            IList<int> pre = null;
            for (int i = 1; i <= numRows; i++)
            {
                IList<int> curr = new List<int>();
                for (int j = 1; j <= i; j++)
                {
                    if (j == 1 || j == i)
                    {
                        curr.Add(1);
                    }
                    else
                    {
                        curr.Add(pre[j - 1] + pre[j - 2]);
                    }
                }
                res.Add(curr);
                pre = curr;
            }
            return res;
        }

        /*
        119. Pascal's Triangle II
        Given a non-negative index k where k ≤ 33, return the kth index row of the Pascal's triangle.
        Note that the row index starts from 0.
        In Pascal's triangle, each number is the sum of the two numbers directly above it.
        Example:
        Input: 3
        Output: [1,3,3,1]
        */
        public IList<int> GetRow(int rowIndex)
        {
            IList<int> res = new List<int>();
            for (int i = 0; i <= rowIndex; i++)
            {
                IList<int> curr = new List<int>(); ;
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                    {
                        curr.Add(1);
                    }
                    else
                    {
                        curr.Add(res[j - 1] + res[j]);
                    }
                }
                res = curr;
            }
            return res;
        }
    }
}