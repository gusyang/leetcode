/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 */
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        //return force(nums,target);
        return point(nums,target);
    }

    private int[] force(int[] nums, int target){    
        for(int i=0;i<nums.Length;i++){
            for(int j=i+1;j<nums.Length;j++){
                if(nums[i]+nums[j]==target){
                    return new int[]{i,j};
                }
            }
        }
        return  new int[0];
    }

    private int[] point(int[] nums,int target){
        List<int> container = new List<int>();
        for(int i=0; i<nums.Length; i++){
            if(container.Contains(target-nums[i])){
                return new int[]{i,container.IndexOf(target-nums[i])};
            }
            container.Add(nums[i]);
        } 
        return new int[0];
    }
}

