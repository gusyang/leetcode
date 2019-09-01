/*
 *
 * [91] Decode Ways
 *
 * https://leetcode.com/problems/decode-ways/description/

 * Testcase Example:  '"12"'
 *
 * A message containing letters from A-Z is being encoded to numbers using the
 * following mapping:
 * 
 * 
 * 'A' -> 1
 * 'B' -> 2
 * ...
 * 'Z' -> 26
 * 
 * 
 * Given a non-empty string containing only digits, determine the total number
 * of ways to decode it.
 * 
 * Example 1:
 * 
 * Input: "12"
 * Output: 2
 * Explanation: It could be decoded as "AB" (1 2) or "L" (12).
 * 
 * Example 2:
 * 
 * Input: "226"
 * Output: 3
 * Explanation: It could be decoded as "BZ" (2 26), "VF" (22 6), or "BBF" (2 2
 * 6).
 * 
 */ 
public class Solution {
    public int NumDecodings(string s) {
        if(s == null || s.Length == 0){
            return 0;
        }
        if(s[0] == '0'){
            return 0;
        }
        int[] dp = new int[s.Length + 1];
        dp[0] = 1;
        dp[1] = 1;
        for(int i = 2; i <= s.Length; i++){
            int first = s[i - 1] - '0';
            int second = (s[i - 2] - '0') * 10 + (s[i - 1] - '0'); 
            if(first >= 1 & first <= 9){
                dp[i] += dp[i - 1];
            }
            if(second >= 10 & second <= 26){
                dp[i] += dp[i - 2];
            }
        }
        return dp[s.Length];
    }
}
 public int NumDecodingsRec(string s) {
      if(s == null || s.Length == 0){
            return 0;
        }
        if(s[0] == '0'){
            return 0;
        }
        Dictionary<int,int> dt = new Dictionary<int,int>();
        return dfs(s,dt,0);
 }
 private int dfs(string s,Dictionary<int,int> map, int idx){
     if(idx == s.Length){
         return 1;
     }
     if(map.ContainsKey(idx)){
         return map[idx];
     }
     if(s[idx] == '0'){
         map.Add(idx,0);
         return 0;
     }
     int res = dfs(s,map,idx + 1);
     if(idx + 1 < s.Length){
         int tmp = (s[idx] - '0') * 10 + (s[idx + 1] - '0');
         if(tmp <= 26){
             res += dfs(s,map,idx + 2);
         }
     }
     map.Add(idx,res);
     return res;
 }
