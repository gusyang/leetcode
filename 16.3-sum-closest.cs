/*
 * @lc app=leetcode id=16 lang=csharp
 *
 * [16] 3Sum Closest
 */
public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        Array.Sort(nums);
        int closest = nums[0] + nums[1] + nums[2];
        int prediff = Int32.MaxValue;
        int left, right;
        for(int i = 0; i<nums.Length; i++){
            left = i + 1;
            right = nums.Length - 1;
            while (left < right)
            {
                int sum = nums[i] + nums[left] + nums[right];
                if(sum == target) return target;

                int diff = Math.Abs(sum - target);
                if(diff < prediff){
                    closest = sum;
                    prediff = diff;
                }

                if(sum > target) right--;
                else left++;

                //closest = Math.Min(Math.Abs(sum - target), Math.Abs(closest - target));
            }
        }
        return closest;
    }
}

