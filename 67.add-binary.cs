/*
 * @lc app=leetcode id=67 lang=csharp
 *
 * [67] Add Binary
 *
 * https://leetcode.com/problems/add-binary/description/
 *
 * algorithms
 * Easy (39.94%)
 * Likes:    1096
 * Dislikes: 210
 * Total Accepted:    327K
 * Total Submissions: 815.2K
 * Testcase Example:  '"11"\n"1"'
 *
 * Given two binary strings, return their sum (also a binary string).
 * 
 * The input strings are both non-empty and contains only characters 1 or 0.
 * 
 * Example 1:
 * 
 * 
 * Input: a = "11", b = "1"
 * Output: "100"
 * 
 * Example 2:
 * 
 * 
 * Input: a = "1010", b = "1011"
 * Output: "10101"
 * 
 */
public class Solution {
    public string AddBinary(string a, string b) {
        StringBuilder sb = new StringBuilder();
        int i = a.Length - 1, j = b.Length - 1, sum = 0;
        while (i >= 0 || j >= 0)
        {
            sum /= 2;
            if(i >= 0){
                sum += a[i--] - '0';
            }
            if(j >= 0){
                sum += b[j--] - '0';
            }
            sb.Insert(0,sum % 2);            
        }
        if(sum / 2 != 0) sb.Insert(0,'1');
        return sb.ToString();
    }

    public int AddBinary1(string a, string b){
        StringBuilder sum = new StringBuilder();
        int i = a.Length - 1, j = b.Length - 1;
        int carry = 0;
        while (i >= 0 || j >= 0 || carry == 1) {
            int digitA = i < 0 ? 0 : a[i--]- '0';
            int digitB = j < 0 ? 0 : b[j--] - '0';
            sum.Insert(0, (digitA + digitB + carry) % 2);
            carry = (digitA + digitB + carry) / 2;
        }
        return sum.ToString();
    }
}

