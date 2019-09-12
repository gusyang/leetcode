/*
Given a non-empty array of integers, every element appears twice except for one. Find that single one.
Note:
Your algorithm should have a linear runtime complexity. Could you implement it without using extra memory?
Example 1:

Input: [2,2,1]
Output: 1
Example 2:

Input: [4,1,2,1,2]
Output: 4
 */
using System;
using System.Collections.Generic;
namespace myapp
{
public class SingleNumber{
    public int FindNumber(int[] nums)
    {
        int result = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            result ^= nums[i];
        }
        return result;
    }
    public int FindNumber1(int[] nums){
        HashSet<int> hs = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (hs.Contains(nums[i]))
            {
                hs.Remove(nums[i]);
            }
            else
            {
                hs.Add(nums[i]);
            }
        }
        if (hs.Count > 0)
        {
            return hs.ToArray()[0];
        }
        return -1;
        }
    }
}