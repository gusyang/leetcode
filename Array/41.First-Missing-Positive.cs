/*
41.First Missing Positive
Given an unsorted integer array, find the smallest missing positive integer.
Example 1:
Input: [1,2,0]
Output: 3
Example 2:
Input: [3,4,-1,1]
Output: 2
Example 3:
Input: [7,8,9,11,12]
Output: 1 */
public class Solution {
    public int FirstMissingPositive(int[] nums) {
        if(nums == null|| nums.Length == 0){
            return 1;
        }
        for(int i = 0; i < nums.Length; i++){
            while(nums[i] > 0 && nums[i] <= nums.Length && nums[nums[i] - 1] != nums[i]){
                int tmp = nums[nums[i] - 1];
                nums[nums[i] - 1] = nums[i];
                nums[i] = tmp;
            }
        }
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] != i + 1){
                return i + 1;
            }
        }
        return nums.Length + 1;
    }
}