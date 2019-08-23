/*
* Given an array with n objects colored red, white or blue, sort them in-place so that objects of the same color are adjacent, with the colors in the order red, white and blue.
Here, we will use the integers 0, 1, and 2 to represent the color red, white, and blue respectively.

Note: You are not suppose to use the library's sort function for this problem.
Example:

Input: [2,0,2,1,1,0]
Output: [0,0,1,1,2,2]
Follow up:

A rather straight forward solution is a two-pass algorithm using counting sort.
First, iterate the array counting number of 0's, 1's, and 2's, then overwrite array with total number of 0's, then 1's and followed by 2's.
Could you come up with a one-pass algorithm using only constant space?
 */
namespace leetcode
{

    public static class _75
    {
        public static void SortColors(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return;
            }
            //twi point 
            int length = nums.Length;
            int low = 0, idx = 0, high = length - 1;
            while (idx <= high)
            {
                if (nums[idx] == 0)
                {
                    if (nums[idx] != nums[low])
                    {
                        swap(nums, idx, low);
                    }
                    idx++;
                    low++;

                }
                else if (nums[idx] == 2)
                {
                    if (nums[idx] != nums[high])
                    {
                        swap(nums, idx, high);
                    }
                    high--;
                }
                else
                {
                    idx++;
                }
            }
        }

        private static void swap(int[] nums, int i, int j)
        {
            if (i == j)
            {
                return;
            }
            int tmp = nums[i];
            nums[i] = nums[j];
            nums[j] = tmp;
        }
        public static void SortColorsCount(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return;
            }
            //count 
            int count0 = 0, count1 = 0, count2 = 0;
            int length = nums.Length;
            for (int i = 0; i < length; i++)
            {
                switch (nums[i])
                {
                    case 0:
                        count0++;
                        break;
                    case 1:
                        count1++;
                        break;
                    case 2:
                        count2++;
                        break;
                }
            }
            for (int i = 0; i < length; i++)
            {
                if (i < count0)
                {
                    nums[i] = 0;
                }
                else if (i < count0 + count1)
                {
                    nums[i] = 1;
                }
                else
                {
                    nums[i] = 2;
                }
            }
        }
    }
}
