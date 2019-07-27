/*
 * @lc app=leetcode id=28 lang=csharp
 *
 * [28] Implement strStr()
 */
public class Solution {
    public int StrStr(string haystack, string needle) {
        int i = 0;
        while (i < haystack.Length - needle.Length + 1)
        {
            int j;
            for (j = i; j < i + needle.Length; j++)
                if (haystack[j] != needle[j - i])
                    break;
            if (j == i + needle.Length) return i;
            i++;
        }
        return -1;
    }
}

