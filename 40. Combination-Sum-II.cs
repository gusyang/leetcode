public class Solution
{
    public IList<IList<int>> CombinationSum2(int[] candidates, int target)
    {
        Array.Sort(candidates);
        IList<IList<int>> result = new List<IList<int>>();
        reCombination(result,candidates,target,new List<int>(),0);
        return result;

    }

    private static void reCombination(IList<IList<int>> result, int[] cand, int target, List<int> curr, int start){
        if(target == 0){
            result.Add(new List<int>(curr));
            return;
        }
        if(target < 0) return;
        for(int i = start; i < cand.Length; i++){
            if(i > start && cand[i] == cand[i - 1]) continue;
            curr.Add(cand[i]);
            reCombination(result,cand,target - cand[i],curr,i + 1);
            curr.RemoveAt(curr.Count - 1);
        }
    }
}