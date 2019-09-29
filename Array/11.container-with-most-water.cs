/*
 * @lc app=leetcode id=11 lang=csharp
 *
 * [11] Container With Most Water
 */
public class Solution {
    public int MaxArea(int[] height) {
       //return force(height);
       return point(height);
    }

    private int force(int[] height){
        int result=0;
        for(int i=0; i<height.Length-1;i++){
            for(int j=i+1;j<height.Length;j++){
                int minheight = Math.Min(height[i],height[j]);
                result = Math.Max(result,minheight*(j-i));
            }
        }
        return result;
    }

    private int point(int[] height){
        int left=0, right = height.Length-1;
        int result = 0;
        while(left<right){
            int current = Math.Min(height[left],height[right])*(right-left);
            result = Math.Max(result,current);
            if(height[left]<height[right]) left++;
            else
            {
                right--;
            }
        }
        return result;
    }
}

