/*
 * @lc app=leetcode id=4 lang=csharp
 *
 * [4] Median of Two Sorted Arrays
 */
public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        return usemerge(nums1,nums2);
    }

    private double usemerge(int[] nums1, int[] nums2){
        int[] merged = merge(nums1,nums2);
        int len = merged.Length, mid = 0;
        if(len % 2 == 1){
            mid = (len -1) /2;
            return merged[mid] / 1.0;
        }else{
            mid = len / 2;
            return (merged[mid] + merged[mid - 1]) / 2.0;
        }
    }
    private int[] merge(int[] nums1, int[] nums2){
        int i = 0, j = 0, k = 0;
        int[] result = new int[nums1.Length + nums2.Length];
        while (i<nums1.Length && j < nums2.Length)
        {
            if(nums1[i]<nums2[j]){
                result[k++] = nums1[i++];                
            }else
            {
                result[k++] = nums2[j++];
            }            
        }
        while(nums1.Length > i){
            result[k++] = nums1[i++];
        }

        while(nums2.Length>j){
            result[k++] = nums2[j++];
        }
        return result;
    }
}

