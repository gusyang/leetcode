/*
 * @lc app=leetcode id=66 lang=csharp
 *
 * [66] Plus One
 *
 * https://leetcode.com/problems/plus-one/description/
 *
 * algorithms
 * Easy (41.52%)
 * Likes:    951
 * Dislikes: 1688
 * Total Accepted:    428.2K
 * Total Submissions: 1M
 * Testcase Example:  '[1,2,3]'
 *
 * Given a non-empty array of digits representing a non-negative integer, plus
 * one to the integer.
 * 
 * The digits are stored such that the most significant digit is at the head of
 * the list, and each element in the array contain a single digit.
 * 
 * You may assume the integer does not contain any leading zero, except the
 * number 0 itself.
 * 
 * Example 1:
 * 
 * 
 * Input: [1,2,3]
 * Output: [1,2,4]
 * Explanation: The array represents the integer 123.
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: [4,3,2,1]
 * Output: [4,3,2,2]
 * Explanation: The array represents the integer 4321.
 * 
 */
public class Solution {
    public int[] PlusOne(int[] digits) {
        if(digits = null || digits.Length == 0) return digits;
        int lens = digits.Length;
        for(int i = lens - 1; i >= 0; i++){
            //if < 9, just plus one, and return;
            if(digits[i] < 9){
                digits[i]++;
                return digits;
            }
            //if = 9, just set 0, and if will loop to next.
            digits[i] = 0;
        }
        //if still do not jump out, means all 9 in the input array
        //need create new array,
        int[] res = new int[n + 1]; //default all 0 in new array. 
        res[0] = 1;
        return res;
    }
}

