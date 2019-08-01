/*
 * @lc app=leetcode id=121 lang=csharp
 *
 * [121] Best Time to Buy and Sell Stock
 */
public class Solution {
    public int MaxProfit(int[] prices) {
       // return force(prices);
       return MaxProfit1(prices);
    }

    private static int force(int[] prices){
        if(prices == null || prices.Length <= 1) return 0;
        int maxprofit = 0;
        for(int i = 0; i < prices.Length - 1; i++){
            for(int j = i+1; j < prices.Length; j++){
                maxprofit = Math.Max(maxprofit,prices[j] - prices[i]);
            }
        }
        return maxprofit;
    }

    private static int MaxProfit1(int[] prices){
        if(prices == null || prices.Length <= 1) return 0;
        int minprice = Int32.MaxValue;
        int maxprofit = 0;
        for(int i = 0; i < prices.Length; i++){
            if(prices[i] < minprice) minprice = prices[i];
            if(prices[i] - minprice > maxprofit) maxprofit = prices[i] - minprice;
        }
        return maxprofit;

    }
}

