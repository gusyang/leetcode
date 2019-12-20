/*
152. Maximum Product Subarray
Given an integer array nums, find the contiguous subarray within an array (containing at least one number) which has the largest product.

Example 1:
Input: [2,3,-2,4]
Output: 6
Explanation: [2,3] has the largest product 6.
Example 2:

Input: [-2,0,-1]
Output: 0
Explanation: The result cannot be 2, because [-2,-1] is not a subarray.
*/
public class Solution {
    public int MaxProduct(int[] nums) {
        if(nums == null || nums.Length == 0) {
            return 0;
        }
        if(nums.Length == 1){
            return nums[0];
        }
        int ret = nums[0], max = nums[0], min = nums[0];
        for(int i = 1; i < nums.Length; i++){
            if(nums[i] < 0){
                int tmp = min;
                min = max;
                max = tmp;
            }
            max = Math.Max(nums[i], nums[i] * max);
            min = Math.Min(nums[i], nums[i] * min);
            ret = Math.Max(ret, max);
        }
        return ret;
    }
}