/*
 * [5] Longest Palindromic Substring
 *
 * https://leetcode.com/problems/longest-palindromic-substring/description/

 * Given a string s, find the longest palindromic substring in s. You may
 * assume that the maximum length of s is 1000.
 * 
 * Example 1:
 * 
 * 
 * Input: "babad"
 * Output: "bab"
 * Note: "aba" is also a valid answer.
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: "cbbd"
 * Output: "bb"
 * 
 * 
 */
public class Solution {
    public string LongestPalindrome(string s) {
        return ex(s);
        //return force(s);
    }

    private static string ex(string s){       
            if (s == null || s.Length == 0) return s;
            int startIndex = 0, length = 0, newStart = 0;
            for (int i = 0; i < s.Length; i++){
                //For odd length.
                int tmplen1 = ExtendPallindrome(s, i, i, ref newStart);
                if (tmplen1 > length){
                    length = tmplen1;
                    startIndex = newStart;
                }
                //For even length.
                int tmplen2 = ExtendPallindrome(s, i, i + 1, ref newStart);
                if (tmplen2 > length){
                    length = tmplen2;
                    startIndex = newStart;
                }
            }
            return s.Substring(startIndex, length);
        }
        private static int ExtendPallindrome(string s, int start, int end, ref int newStart)
        {
            while (start >= 0 && end < s.Length && s[start] == s[end])
            {
                start--;
                end++;
            }
            //When calculating newLength;
            //we will have to compensate for one reduction in start and one increment in end;
            //because of the while loop above.           
            // ~ end - start -1
            //int newLength = ((end - 1) - (start + 1)) + 1;
            newStart = start + 1;
            return (end- 1) - (start + 1) + 1;
        }

    private static string force(string s){
        if(s == null || s.Length == 0) return s;
        string result = "";
        int max = 0, size = s.Length;
        for(int i = 0; i < size; i++){
            for(int j = i + 1; j <= size; j++){
                string tmp = s.Substring(i,j);
                if(isPalindrome(tmp) && tmp.Length > max){
                    result = tmp;
                    max = tmp.Length;
                }
            }            
        }
        return result;
    }
 
    private static bool isPalindrome(string s){
        if(s.Length < 2) return false;
        for(int i = 0; i < s.Length / 2; i++){
            if(s[i] != s[s.Length - i - 1]) return false;
        }
        return true;
    }
}

