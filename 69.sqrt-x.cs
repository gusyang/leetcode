/*
 * @lc app=leetcode id=69 lang=csharp
 *
 * [69] Sqrt(x)
 *
 * https://leetcode.com/problems/sqrtx/description/
 *
 * algorithms
 * Easy (31.90%)
 * Likes:    847
 * Dislikes: 1471
 * Total Accepted:    402.3K
 * Total Submissions: 1.3M
 * Testcase Example:  '4'
 *
 * Implement int sqrt(int x).
 * 
 * Compute and return the square root of x, where x is guaranteed to be a
 * non-negative integer.
 * 
 * Since the return type is an integer, the decimal digits are truncated and
 * only the integer part of the result is returned.
 * 
 * Example 1:
 * 
 * 
 * Input: 4
 * Output: 2
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: 8
 * Output: 2
 * Explanation: The square root of 8 is 2.82842..., and since 
 * the decimal part is truncated, 2 is returned.
 * 
 * 
 */
public class Solution {
    public int MySqrt(int x) {
        //BS
        int mid, left = 2, right = x / 2;
        while (true) {
          mid = left + (right - left) / 2;
          //num = (long)pivot * pivot;
          if (mid > x/mid) right = mid - 1;
          else { 
              if(mid + 1 > x/(mid + 1)) return mid;
            left = mid + 1;
          }
        }
    }
//too slow and hard to understand.
    public int MySqrt1(int x) {
        int curr = 0;
        int res = 0;
        int add = 1;
        while (curr <= x)
        {
            if(int.MaxValue - curr < add) return res;
            curr += add;
            res++;
            add += 2;
        }
        return res - 1;
    }
}

