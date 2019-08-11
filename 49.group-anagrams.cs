/*
 * @lc app=leetcode id=49 lang=csharp
 *
 * [49] Group Anagrams
 *
 * https://leetcode.com/problems/group-anagrams/description/
 *
 * algorithms
 * Medium (48.23%)
 * Likes:    1881
 * Dislikes: 123
 * Total Accepted:    374.2K
 * Total Submissions: 772.9K
 * Testcase Example:  '["eat","tea","tan","ate","nat","bat"]'
 *
 * Given an array of strings, group anagrams together.
 * 
 * Example:
 * 
 * 
 * Input: ["eat", "tea", "tan", "ate", "nat", "bat"],
 * Output:
 * [
 * ⁠ ["ate","eat","tea"],
 * ⁠ ["nat","tan"],
 * ⁠ ["bat"]
 * ]
 * 
 * Note:
 * 
 * 
 * All inputs will be in lowercase.
 * The order of your output does not matter.
 * 
 * 
 */
public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        if(strs == null || strs.Length == 0) return null;
        Dictionary<string,List<string>> dt = new Dictionary<string,List<string>>();
        foreach(string s in strs){
            char[] ch = s.ToCharArray();
            Array.Sort(ch);
            string key = new string(ch);
            if(!dt.ContainsKey(key)){
                dt[key] = new List<string>();
            }
            dt[key].Add(s);                   
        }
        /*
        IList<IList<string>> result = new List<IList<string>>();
        foreach(KeyValuePair<string,List<string>> kv in dt){
            result.Add(kv.Value);
        }
        */
        return new List<IList<string>>(dt.Values);
    }
}

