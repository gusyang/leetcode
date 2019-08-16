/*
The set [1,2,3,...,n] contains a total of n! unique permutations.

By listing and labeling all of the permutations in order, we get the following sequence for n = 3:
"123"
"132"
"213"
"231"
"312"
"321"
Given n and k, return the kth permutation sequence.

Note:

Given n will be between 1 and 9 inclusive.
Given k will be between 1 and n! inclusive.
Example 1:

Input: n = 3, k = 3
Output: "213"
Example 2:

Input: n = 4, k = 9
Output: "2314"
 */
public class Solution
{
    public string GetPermutation(int n, int k)
    {
        int[] fac = new int[n + 1];
        List<int> nums = new List<int>();
        StringBuilder sb = new StringBuilder();

        //create array, fac[n] = {1,1,2,...n!}
        //nums for index
        fac[0] = 1;
        for(int i = 1; i <= n; i++){           
            fac[i] = i * fac[i - 1];
            nums.Add(i);
        }
        k--;
        for(int i = 1; i <= n; i++){
            int idx = k / fac[n - i];
            sb.Append(nums[idx]);
            nums.RemoveAt(idx);
            k -= idx * fac[n - i];
        }
        return sb.ToString();

    }
}