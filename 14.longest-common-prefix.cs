/*
 * @lc app=leetcode id=14 lang=csharp
 *
 * [14] Longest Common Prefix
 */
public class Solution {
    public string LongestCommonPrefix(string[] strs) {        
        //return l1(strs);
        return l2(strs);
    }
    private string l1(string[] strs){        
        if(strs == null || strs.Length == 0) return "";      
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < strs[0].Length; i++){
            for(int j = 1; j < strs.Length; j++){
                if(i > strs[j].Length || strs[j][i] != strs[0][i]){ 
                    return sb.ToString();
                    }
            }
            sb.Append(strs[0][i]);
        }
        return sb.ToString();
    }

    private string l2(string[] strs){
        if(strs == null || strs.Length == 0) return ""; 
        string Prefix = strs[0];
        for(int i = 0; i < strs.Length; i++){
            int minLength = Math.Min(Prefix.Length, strs[i].Length);
            int j = 0;
            for(; j < minLength; j++){
                if(Prefix[j] != strs[i][j]) break;
            }
            Prefix = Prefix.Substring(0,j);
        }
       return Prefix; 
    }
}

