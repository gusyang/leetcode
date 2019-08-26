/*
 *78. Subsets
Given a set of distinct integers, nums, return all possible subsets (the power set).
Note: The solution set must not contain duplicate subsets.

Example:
Input: nums = [1,2,3]
Output:
[
  [3],
  [1],
  [2],
  [1,2,3],
  [1,3],
  [2,3],
  [1,2],
  []
] 
 */
namespace ConsoleApp1
{
    class _78
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            if(nums == null || nums.Length == 0)
            {
                return new List<IList<int>>();
            }
            IList<IList<int>> res = new List<IList<int>>();
            SubsetRec(res, new List<int>(), 0, nums);
            return res;

        }

        private static void SubsetRec(IList<IList<int>> res, List<int> curr, int start,int[] nums)
        {
            res.Add(new List<int> ( curr ));
            for(int i = start; i < nums.Length; i++)
            {
                curr.Add(nums[i]);
                SubsetRec(res, curr, i + 1, nums);
                curr.RemoveAt(curr.Count - 1);
            }
        }
    }
}
