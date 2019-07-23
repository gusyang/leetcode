/*
 * @lc app=leetcode id=26 lang=csharp
 *
 * [26] Remove Duplicates from Sorted Array
 */
public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if(nums == null ||nums.Length == 0)
            return 0;
        int returnvalue = 0;
        for(int i = 0; i < nums.Length; i++ ){
            if(i == 0 || nums[i] != nums[i-1]){
                nums[returnvalue++] = nums[i];
            }
        }
        return returnvalue;
        
    }
}

