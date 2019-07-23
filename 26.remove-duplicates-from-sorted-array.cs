/*
 * @lc app=leetcode id=26 lang=csharp
 *
 * [26] Remove Duplicates from Sorted Array
 */
public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if(nums == null || nums.Length == 0) return 0;
        int result = 0;
        for(int i = 1; i < nums.Length ; i++){
           if(nums[i] != nums[result]) 
           {
                result++;
               nums[result] = nums[i];
           }
        }
        return result + 1;
    }
}

