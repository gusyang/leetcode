/*
Given a collection of integers that might contain duplicates, nums, return all possible subsets (the power set).
Note: The solution set must not contain duplicate subsets.
Example:
Input: [1,2,2]
Output:
[
  [2],
  [1],
  [1,2,2],
  [2,2],
  [1,2],
  []
]
 */
 public class Solution {
    public IList<IList<int>> SubsetsWithDup(int[] nums) {
        if(nums == null || nums.Length == 0)
        {
            return new List<IList<int>>();
        }
        Array.Sort(nums);
        IList<IList<int>> res = new List<IList<int>>();
        SubsetRec(res, new List<int>(), 0, nums);
        return res;
    }
    private static void SubsetRec(IList<IList<int>> res, List<int> curr, int start,int[] nums)
        {
            res.Add(new List<int> ( curr ));
            //if(start == nums.Length - 1) return;
            for(int i = start; i < nums.Length; i++)
            {
                if(i != start && nums[i - 1] == nums[i]) continue;
                curr.Add(nums[i]);
                SubsetRec(res, curr, i+1, nums);
                curr.RemoveAt(curr.Count - 1);
            }
        }
    }
