/*
 * @lc app=leetcode id=3 lang=csharp
 *
 * [3] Longest Substring Without Repeating Characters
 */
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> hs = new HashSet<char>();
        int ret = 0, right=0, left=0;
        while (right < s.Length)
        {
            if(!hs.Contains(s[right])){
                hs.Add(s[right]);
                ret = Math.Max(ret,hs.Count);
                right++;
            } else
            {
                hs.Remove(s[left]);
                left++;
            }
        }
        return ret;

    }
}

