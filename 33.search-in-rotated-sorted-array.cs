/*
 * @lc app=leetcode id=33 lang=csharp
 *
 * [33] Search in Rotated Sorted Array
 */
public class Solution {
    public int Search(int[] nums, int target) {
        if(nums == null || nums.Length == 0) return -1;
        int result = -1;
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] == target) {
                result = i;
                break;
                }
        }
        return result;
    }
}

