/*
 * @lc app=leetcode id=31 lang=csharp
 *
 * [31] Next Permutation
 */
public class Solution {
    public void NextPermutation(int[] nums) {
        int i = nums.Length - 2;
        //find first permutation position
        while(i >= 0 && nums[i+1] <= nums[i]){
            i--;
        }

        //if to the left, reservse
        if(i < 0){
            reverse(nums,0);
            return;
        }

        int j = nums.Length - 1;
        while(j >= 0 && nums[j] <= nums[i]){
            j--;
        }
        swap(nums,i,j);

        reverse(nums,i + 1);
    }

    private void swap(int[] nums, int i, int j){
        int temp = nums[j];
        nums[j] = nums[i];
        nums[i] = temp;
    }

    private void reverse(int[] nums, int start){
        int i = start, j = nums.Length - 1;
        while(i < j){
            swap(nums,i,j);
            i++;
            j--;
        }
    }
}

