using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions.Two_pointers
{
    public class SquaresSortedArray
    {
        /*  977. Squares of a Sorted Array https://leetcode.com/problems/squares-of-a-sorted-array/
         *  Given an integer array nums sorted in non-decreasing order,
         *  return an array of the squares of each number sorted in non-decreasing order.
         */
        public int[] SortedSquares(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;
            int aux = nums.Length - 1;
            int[] result = new int[nums.Length];

            while (left <= right)
            {
                if (Math.Abs(nums[left]) > Math.Abs(nums[right]))
                {
                    result[aux] = nums[left] * nums[left];
                    left++;
                }

                else
                {
                    result[aux] = nums[right] * nums[right];
                    right--;
                }

                aux--;

            }

            return result;

        }
    }
}
