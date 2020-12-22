using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions.Two_pointers
{
    /*  167. Two Sum II - Input array is sorted https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
        Given an array of integers that is already sorted in ascending order,
        find two numbers such that they add up to a specific target number.
        The function twoSum should return indices of the two numbers such that they add up to the target,
        where index1 must be less than index2.
        Note:
        Your returned answers (both index1 and index2) are not zero-based.
        You may assume that each input would have exactly one solution and you may not use the same element twice.
    */
    public class TwoSumII
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int left = 0;
            int right = numbers.Length - 1;

            while (left <= right)
            {
                if (numbers[left] + numbers[right] == target)
                {
                    return new int[] { left + 1, right + 1 };
                }
                else if (numbers[left] + numbers[right] > target)
                {
                    right--;
                }

                else
                {
                    left++;
                }
            }

            return null;
        }
    }
}
