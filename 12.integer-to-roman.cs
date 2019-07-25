/*
 * @lc app=leetcode id=12 lang=csharp
 *
 * [12] Integer to Roman
 */
public class Solution {
    public string IntToRoman(int num) {       
        
        if (num <= 0)
        {
            return string.Empty;
        }
        int[] nums = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        IDictionary<int, string> romans = new Dictionary<int, string>{
        {1000, "M"},
        {900, "CM"},
        {500, "D"},
        {400, "CD"},
        {100, "C"},
        {90, "XC"},
        {50, "L"},
        {40, "XL"},
        {10, "X"},
        {9, "IX"},
        {5, "V"},
        {4, "IV"},
        {1, "I"}
        }; 
        
        var sb = new StringBuilder();
        while (num > 0)
        {
            for (int idx = 0; idx < nums.Length; idx++)
            {
                if (num / nums[idx] > 0)
                {
                    int div = num / nums[idx];
                    while (div > 0)
                    {
                        sb.Append(romans[nums[idx]]);
                        div--;
                    }
                    num %= nums[idx];
                    break;
                }
            }
        }
        return sb.ToString();
    }
}

