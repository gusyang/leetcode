/*
 * @lc app=leetcode id=18 lang=csharp
 *
 * [18] 4Sum
 */
public class Solution {
    public IList<IList<int>> FourSum(int[] nums, int target) {
       return from3sum(nums,target);
    }

    private IList<IList<int>> from3sum(int[] nums, int target) {
        IList<IList<int>> result = new List<IList<int>>();
        if(nums == null || nums.Length <4) return result;
        Array.Sort(nums);

        for(int i = 0; i < nums.Length - 3; i++){
            if(i != 0 && nums[i] == nums[i - 1]) continue;
            for(int j = i + 1; j < nums.Length - 2; j++){
                if(j != i + 1 && nums[j] == nums[j - 1]) continue;

                int left = j + 1, right = nums.Length - 1;
                while (left < right)
                {
                    int lsum = nums[i] + nums[j] + nums[left] + nums[right];
                    if(lsum == target){
                        result.Add(
                            new List<int>{
                                nums[i],nums[j],nums[left],nums[right]
                            }
                        );

                        while(left < right && nums[left] == nums[left + 1]) left++;
                        while(left < right && nums[right] == nums[right - 1]) right--;
                        left++;
                        right--;
                    }else if(lsum < target){
                        left++;
                    } else{
                        right--;
                    }                
                    
                }

            }
        }
        return result;
    }
}

