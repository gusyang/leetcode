/*
 76. Minimum Window Substring
Given a string S and a string T, find the minimum window in S which will contain all the characters in T in complexity O(n).
Example:
Input: S = "ADOBECODEBANC", T = "ABC"
Output: "BANC"
Note:
If there is no such window in S that covers all characters in T, return the empty string "".
If there is such window, you are guaranteed that there will always be only one unique minimum window in S.
 */
namespace ConsoleApp1
{
    public static class _76
    {
        public static string MinWindow(string s, string t)
        {
            if (s == null || t == null || s.Length == 0 || t.Length == 0)
            {
                return "";
            }
            string res = "";
            int[] tarray = new int[256];
            int[] sarray = new int[256];
            foreach (char c in t)
            {
                tarray[c]++;
            }
            int left = findNextChar(0, s, tarray);
            if(left == s.Length)
            {
                //not find
                return "";
            }
            int right = left;
            int matchcount = 0;
            while(right < s.Length)
            {
                int rightchar = s[right];
                if(sarray[rightchar] < tarray[rightchar])
                {
                    matchcount++;
                }
                sarray[rightchar]++;
                while(left < s.Length && matchcount == t.Length)
                {
                    if(String.IsNullOrEmpty(res) || res.Length > right - left + 1)
                    {
                        res = s.Substring(left, right - left + 1);
                    }
                    int leftchar = s[left];
                    if(sarray[leftchar] <= tarray[leftchar])
                    {
                        matchcount--;
                    }
                    sarray[leftchar]--;
                    left = findNextChar(left + 1, s, tarray);
                }
                right = findNextChar(right + 1, s, tarray);
            }

            return res;
        }
        private static int findNextChar(int start, string s, int[] tarray)
        {
            while (start < s.Length)
            {
                if (tarray[s[start]] != 0)
                {
                    return start;
                }
                start++;
            }
            return start;
        }
    }
}
