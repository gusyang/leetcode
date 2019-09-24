/*
 * @lc app=leetcode id=125 lang=csharp
 *
 * [125] Valid Palindrome
 *
 * https://leetcode.com/problems/valid-palindrome/description/
 * Testcase Example:  '"A man, a plan, a canal: Panama"'
 *
 * Given a string, determine if it is a palindrome, considering only
 * alphanumeric characters and ignoring cases.
 * 
 * Note: For the purpose of this problem, we define empty string as valid
 * palindrome.
 * 
 * Example 1:
 * 
 * 
 * Input: "A man, a plan, a canal: Panama"
 * Output: true
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: "race a car"
 * Output: false
 * 
 * 
 */
public class Solution {
    public bool IsPalindrome(string s) {
        if(s == null || s.Length == 0){
            return true;
        }
        s = s.ToLower();
        int left = 0, right = s.Length - 1;        
        while (left < right){
            if(!Char.IsLetterOrDigit(s[left])){
                left++;
            }else if(!Char.IsLetterOrDigit(s[right])){
                right--;
            }else if(s[left] != s[right]) {
                return false;
            }  else {
                left++;
                right--;
            }
        }
        return true;
    }
}

