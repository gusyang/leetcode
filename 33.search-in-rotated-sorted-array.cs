/*
 * @lc app=leetcode id=33 lang=csharp
 *Suppose an array sorted in ascending order is rotated at some pivot unknown to you beforehand.
 *(i.e., [0,1,2,4,5,6,7] might become [4,5,6,7,0,1,2]).
 *You are given a target value to search. If found in the array return its index, otherwise return -1.
 *You may assume no duplicate exists in the array.
 *Your algorithm's runtime complexity must be in the order of O(log n).
 * [33] Search in Rotated Sorted Array
 */
public class Solution {
    public int Search(int[] nums, int target) {       
        //return ON(nums, target);
        return Bsearch(nums,target);
    }

    private static int Bsearch(int[] nums, int target){
        if(nums == null || nums.Length == 0) return -1;
        int start = 0, end = nums.Length - 1;

        while (start + 1 < end)
        {
            int mid = start + (end - start) / 2;
            if(nums[mid] == target) return mid;
            if(nums[mid] >= nums[start] ){ 
                if(target >= nums[start] && target <= nums[mid])
                    end = mid;
                else
                    start = mid;
            }
            else if(nums[mid] < nums[end]) {
                if(target <= nums[end] && target >= nums[mid])
                    start = mid;
                else
                    end = mid;
            }
        }

        if(nums[start] == target ) return start;
        if(nums[end] == target ) return end;

        return -1;
    }
    ///time complexity is O(N), not a good solution
    private static int ON (int[] nums, int target) {
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

