/*
 * @lc app=leetcode id=10 lang=csharp
 *
 * [10] Regular Expression Matching
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
            return this.isMatchRecursion(s, 0, p, 0);
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

