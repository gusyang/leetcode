/*
131. Palindrome Partitioning
Given a string s, partition s such that every substring of the partition is a palindrome.
Return all possible palindrome partitioning of s.
Example:
Input: "aab"
Output:
[
  ["aa","b"],
  ["a","a","b"]
]
 */
public class Solution
{
    public IList<IList<string>> Partition(string s)
    {
        IList<IList<string>> res = new List<IList<string>>();
        IList<string> curr = new List<string>();
        DFS(s,0,res,curr);
        return res;
    }
    private void DFS(string s, int pos, IList<IList<string>> res, IList<string> curr){
        if(pos == s.Length){
            res.Add(new List<string>(curr));
            return;
        }
        for(int i = pos; i < s.Length;i++){
            if(isPalindrome(s,pos,i)){
                curr.Add(s.Substring(pos,i - pos + 1));
                DFS(s,i+1,res,curr);
                curr.RemoveAt(curr.Count - 1);
            }
        }
    }
    private bool isPalindrome(string s, int left, int right){
        while (left < right){
            if(s[left] != s[right]){
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}