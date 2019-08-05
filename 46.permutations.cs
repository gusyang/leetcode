/*
 * @lc app=leetcode id=46 lang=csharp
 *
 * [46] Permutations
 */
public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        int n = nums.Length;
       IList<IList<int>> lists = new List<IList<int>>();

       if(nums == null || n == 0) 
       return lists;
       recPermute(lists, nums, new List<int>(),new bool[n]);
       return lists;
    }

    private  void recPermute(IList<IList<int>> lists, int[] nums, List<int> cur, bool[] used){
        int n = nums.Length;
        if(cur.Count == n){
            lists.Add(new List<int>(cur));
            return;
        }

        for(int i = 0; i < n; i++){
            if(used[i]) continue;
            cur.Add(nums[i]);
            used[i] = true;
            recPermute(lists,nums,cur,used);
            used[i] = false;
            cur.RemoveAt(cur.Count - 1);
        }
    }
}

