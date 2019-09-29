/*
 * @lc app=leetcode id=35 lang=csharp
 *
 * [35] Search Insert Position
 *
 * https://leetcode.com/problems/search-insert-position/description/
 *
 * algorithms
 * Easy (41.06%)
 * Likes:    1436
 * Dislikes: 191
 * Total Accepted:    431.5K
 * Total Submissions: 1.1M
 * Testcase Example:  '[1,3,5,6]\n5'
 *
 * Given a sorted array and a target value, return the index if the target is
 * found. If not, return the index where it would be if it were inserted in
 * order.
 * 
 * You may assume no duplicates in the array.
 * 
 * Example 1:
 * 
 * 
 * Input: [1,3,5,6], 5
 * Output: 2
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: [1,3,5,6], 2
 * Output: 1
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: [1,3,5,6], 7
 * Output: 4
 * 
 * 
 * Example 4:
 * 
 * 
 * Input: [1,3,5,6], 0
 * Output: 0
 * 
 * 
 */
public class Solution {
    public int SearchInsert(int[] nums, int target) {
        //return forloop(nums,target);
        return bsearch(nums,target);
    }

    private static int forloop(int[] nums, int target) {
        if(nums == null || nums.Length == 0) return 0;

        int  size = nums.Length;
        if(nums[0] > target) return 0;
        if(nums[size - 1] < target) return size;
        for(int i = 0; i < size; i++){
            if(nums[i] >= target ) return i;
            //if(nums[i] > target) return i - 1;
        }
        return 0;
    }

    private static int bsearch(int[] nums, int target){
        
        if(nums == null || nums.Length == 0 || nums[0] > target) return 0;
        
        int low = 0,  size = nums.Length;
        if(nums[size - 1] < target) return size;
        while(low < size){
            int mid = (low + size) / 2;
            if(nums[mid] == target) return mid;
            else if(nums[mid] > target) size = mid;
            else low = mid + 1; 
        }
        return low;
    }
}

