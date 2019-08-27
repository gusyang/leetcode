using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 81. Search in Rotated Sorted Array II
Suppose an array sorted in ascending order is rotated at some pivot unknown to you beforehand.
(i.e., [0,0,1,2,2,5,6] might become [2,5,6,0,0,1,2]).
You are given a target value to search. If found in the array return true, otherwise return false.

Example 1:

Input: nums = [2,5,6,0,0,1,2], target = 0
Output: true
Example 2:
Input: nums = [2,5,6,0,0,1,2], target = 3
Output: false
Follow up:

This is a follow up problem to Search in Rotated Sorted Array, where nums may contain duplicates.
Would this affect the run-time complexity? How and why?*/
namespace ConsoleApp1
{
    public static class _81
    {
        public bool Search(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
            {
                return false;
            }
            int left = 0, right = nums.Length - 1;
            
                
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if(nums[mid] == target)
                {
                    return true;
                }

                if(nums[left] < nums[mid])
                {
                    if(nums[left] <= target && target <= nums[mid])
                    {
                        right = mid;
                    } else
                    {
                        left = mid;
                    } 
                } else if(nums[mid] < nums[left])
                {
                    if(nums[mid] >= target && nums[right] >= target)
                    {
                        left = mid;
                    } else
                    {
                        right = mid;
                    }
                }
                else
                {
                    left++;
                }                
            }
            if(nums[left] == target || nums[right] == target)
            {
                return true;
            }
            return false;
        }
    }
}
