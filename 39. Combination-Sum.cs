/*
Given a set of candidate numbers (candidates) (without duplicates) and a target number (target), find all unique combinations in candidates where the candidate numbers sums to target.

The same repeated number may be chosen from candidates unlimited number of times.

Note:

All numbers (including target) will be positive integers.
The solution set must not contain duplicate combinations.
Example 1:

Input: candidates = [2,3,6,7], target = 7,
A solution set is:
[
  [7],
  [2,2,3]
]
Example 2:

Input: candidates = [2,3,5], target = 8,
A solution set is:
[
  [2,2,2,2],
  [2,3,3],
  [3,5]
]
*/
public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        IList<IList<int>> result = new List<IList<int>>();
        if(candidates == null) return result;
        reCombin(result,candidates,target,0,new List<int>());
        return result;
    }

    private void reCombin(IList<IList<int>> result, int[] cand, int target, int start, List<int> curr){
        if(target == 0){
            result.Add(new List<int>(curr));
            return;
        }

        for(int i = start; i < cand.Length ; i++){
            if(target < cand[i]) break;
            curr.Add(cand[i]);
            reCombin(result,cand,target - cand[i],i,curr);
            curr.RemoveAt(curr.Count - 1);
        }
    }
}
