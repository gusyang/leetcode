
/*
77. Combinations
Share
Given two integers n and k, return all possible combinations of k numbers out of 1 ... n.

Example:

Input: n = 4, k = 2
Output:
[
  [2,4],
  [3,4],
  [2,3],
  [1,2],
  [1,3],
  [1,4],
]
 */
namespace ConsoleApp1
{
    public static class _77
    {
        public static IList<IList<int>> Combine(int n, int k)
        {
            if(n == 0 || k == 0)
            {
                return new List<IList<int>>();
            }
            IList<IList<int>> res = new List<IList<int>>();
            Backtrack(res, new List<int>(), 1, n, k);
            return res;

        }
        private static void Backtrack(IList<IList<int>> res, List<int> curr, int start, int n, int k)
        {
            if(k == 0)
            {
                res.Add(new List<int>(curr));
                return ;
            }
            for(int i = start; i < n - k + 1; i++)
            {
                curr.Add(i);
                Backtrack(res, curr, i + 1, n, k - 1);
                curr.RemoveAt(curr.Count - 1);
            }
        }
    }
}
