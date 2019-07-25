/*
 * @lc app=leetcode id=34 lang=csharp
 *
 * [34] Find First and Last Position of Element in Sorted Array
 */
public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        if(nums == null || nums.Length == 0) 
            return new int[] {-1,-1};
        int[] result = new int[] {-1,-1};
        for(int i = 0; i < nums.Length - 1; i++){
            if(nums[i] == target){
                result[0] = i;
                break;
            }            
        }
        if(result[0] == -1) 
            return result;

        for(int j = nums.Length - 1; j>0; j--){
            if(nums[j] == target){
                result[1] = j;
                break;
            }
        }
        return result;
    }
}

