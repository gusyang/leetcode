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