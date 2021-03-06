/*
 * @lc app=leetcode id=122 lang=csharp
 *
 * [122] Best Time to Buy and Sell Stock II
 *
 * https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii/description/
 *
 * algorithms
 * Easy (52.55%)
 * Likes:    1141
 * Dislikes: 1359
 * Total Accepted:    350.9K
 * Total Submissions: 667.1K
 * Testcase Example:  '[7,1,5,3,6,4]'
 *
 * Say you have an array for which the i^th element is the price of a given
 * stock on day i.
 * 
 * Design an algorithm to find the maximum profit. You may complete as many
 * transactions as you like (i.e., buy one and sell one share of the stock
 * multiple times).
 * 
 * Note: You may not engage in multiple transactions at the same time (i.e.,
 * you must sell the stock before you buy again).
 * 
 * Example 1:
 * 
 * 
 * Input: [7,1,5,3,6,4]
 * Output: 7
 * Explanation: Buy on day 2 (price = 1) and sell on day 3 (price = 5), profit
 * = 5-1 = 4.
 * Then buy on day 4 (price = 3) and sell on day 5 (price = 6), profit = 6-3 =
 * 3.
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: [1,2,3,4,5]
 * Output: 4
 * Explanation: Buy on day 1 (price = 1) and sell on day 5 (price = 5), profit
 * = 5-1 = 4.
 * Note that you cannot buy on day 1, buy on day 2 and sell them later, as you
 * are
 * engaging multiple transactions at the same time. You must sell before buying
 * again.
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: [7,6,4,3,1]
 * Output: 0
 * Explanation: In this case, no transaction is done, i.e. max profit = 0.
 * 
 */
public class Solution {
    public int MaxProfit(int[] prices) {
        if(prices == null || prices.Length < 2) return 0;
        int i = 0, maxprofit = 0, v = prices[0], p = prices[0];
        while( i < prices.Length - 1 ){
            while(i < prices.Length - 1 && prices[i] <= prices[i + 1]) i++;
            v = prices[i];
            while(i < prices.Length - 1 && prices[i] >= prices[i + 1]) i++;
            p = prices[i];
            maxprofit += p - v;
        }

        return maxprofit;
    }
    
     public int MaxProfit(int[] prices) {
        int max = 0;
        for(int i = 1; i < prices.Length; i++ ){
            if(prices[i] > prices[i - 1]){
                max += prices[i] - prices[i - 1];
            }
        }
        return max;
    }
}

