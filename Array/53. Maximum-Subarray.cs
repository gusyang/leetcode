/*
Given an integer array nums, find the contiguous subarray (containing at least one number) which has the largest sum and return its sum.
Example:

Input: [-2,1,-3,4,-1,2,1,-5,4],
Output: 6
Explanation: [4,-1,2,1] has the largest sum = 6.
 */
public class Solution
{
    public int MaxSubArray(int[] nums)
    {
        if(nums == null || nums.Length == 0) return 0;
        int maxToCurr = nums[0], res = nums[0];
        for(int i =0; i < nums.Length; i++){
            maxToCurr = Math.Max(maxToCurr + nums[i], nums[i]);
            res = Math.Max(res,maxToCurr);
        }
        return res;

    }
}