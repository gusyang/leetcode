/*
  Given an input string (s) and a pattern (p), implement regular expression matching with support for '.' and '*'.

'.' Matches any single character.
'*' Matches zero or more of the preceding element.

The matching should cover the entire input string (not partial).

Note:

    s could be empty and contains only lowercase letters a-z.
    p could be empty and contains only lowercase letters a-z, and characters like . or *.

Example 1:

Input:
s = "aa"
p = "a"
Output: false
Explanation: "a" does not match the entire string "aa".

Example 2:

Input:
s = "aa"
p = "a*"
Output: true
Explanation: '*' means zero or more of the precedeng element, 'a'. Therefore, by repeating 'a' once, it becomes "aa".

我们也可以用 DP 来解，定义一个二维的 DP 数组，其中 dp[i][j] 表示 s[0,i) 和 p[0,j) 是否 match，然后有下面三种情况：

1.  P[i][j] = P[i - 1][j - 1], if p[j - 1] != '' && (s[i - 1] == p[j - 1] || p[j - 1] == '.');
2.  P[i][j] = P[i][j - 2], if p[j - 1] == '' and the pattern repeats for 0 times;
3.  P[i][j] = P[i - 1][j] && (s[i - 1] == p[j - 2] || p[j - 2] == '.'), if p[j - 1] == '*' and the pattern repeats for at least 1 times.
 */
public class Solution {
    public bool IsMatch(string s, string p) {        
         if (p == null && s == null)
            {
                return true;
            }
            if (p == null || s == null)
            {
                return false;
            }
        
            int slen = s.Length, plen = p.Length;
            bool[][] dp = new bool[slen + 1][];
            for(int i = 0; i <= slen; i++)
            {
                dp[i] = new bool[plen + 1];
            }
            //dp array, dp[s string length][p string length], value present if current match
            dp[0][0] = true; 
            //init *
            for(int i = 1; i <= plen; i++)
            {
                if(p[i - 1] == '*')
                {
                    dp[0][i] = dp[0][i - 2];
                }
            }

            for(int si = 1; si <= slen; si++)
            {
                for(int pi = 1; pi <= plen; pi++)
                {
                    if(p[pi - 1] == s[si - 1] || p[pi - 1] == '.')
                    {
                        dp[si][pi] = dp[si - 1][pi - 1];
                    } else if (p[pi - 1] == '*')
                    {
                        if(p[pi - 2] == s[si - 1] || p[pi - 2] == '.')
                        {
                            dp[si][pi] = dp[si][pi - 2] || dp[si - 1][pi];
                        }
                        else
                        {
                            dp[si][pi] = dp[si][pi - 2];
                        }
                    }
                }
            }
            return dp[slen][plen];
        //    return this.isMatchRecursion(s, 0, p, 0);
    }
    private bool isMatchRecursion(String s, int indexOfs, String p, int indexofp)
        {
            if (indexOfs >= s.Length)
            {
                while (indexofp + 1 < p.Length && p[indexofp + 1].Equals('*'))                 
                {                     
                    indexofp += 2;                 
                }             
            }             
            if (indexOfs >= s.Length && indexofp >= p.Length)
            {
                return true;
            }
            if (indexOfs >= s.Length || indexofp >= p.Length)
            {
                return false;
            }

            var next = indexofp + 1 >= p.Length ? ' ' : p[indexofp + 1];

            if (next.Equals('*'))
            {
                if (s[indexOfs].Equals(p[indexofp]) || p[indexofp].Equals('.'))
                {
                    // a* matches more than 0 of a in s
                    return this.isMatchRecursion(s, indexOfs + 1, p, indexofp) 
                        // a* matches 0 of a in s
                        || this.isMatchRecursion(s, indexOfs, p, indexofp + 2);
                }
                
                return this.isMatchRecursion(s, indexOfs, p, indexofp + 2);
            }

            if (s[indexOfs].Equals(p[indexofp]) || p[indexofp].Equals('.'))
            {
                return this.isMatchRecursion(s, indexOfs + 1, p, indexofp + 1);
            }

            return false;
        }
}

