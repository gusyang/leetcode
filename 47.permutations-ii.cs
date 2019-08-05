/*
 * @lc app=leetcode id=47 lang=csharp
 *
 * [47] Permutations II
 */
public class Solution {
    public IList<IList<int>> PermuteUnique(int[] nums) {
        IList<IList<int>> result = new List<IList<int>>();
        int n = nums.Length;
        if(nums == null || n == 0 ) return result;

        Array.Sort(nums);
        rePernute(result,nums,new List<int>(), new bool[n] );

        return result;        
    }

    private void rePernute(IList<IList<int>> result, int[] nums, List<int> cur, bool[] used){
        int n = nums.Length;
        if(cur.Count == n){
            result.Add(new List<int>(cur));
            return;
        }

        for(int i = 0; i < n; i++){
            if(used[i] || (i > 0 && nums[i - 1 ] == nums[i] && !used[i - 1]) ){
                continue;
            }
            cur.Add(nums[i]);
            used[i] = true;
            rePernute(result, nums, cur, used);
            used[i] = false;
            cur.RemoveAt(cur.Count - 1);
        }
    }
}

