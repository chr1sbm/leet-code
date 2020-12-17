using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions.Arrays
{
    public class MajorityElement
    {   /*  169. Majority Element https://leetcode.com/problems/majority-element/
            Given an array of size n, find the majority element.
            The majority element is the element that appears more than ⌊ n/2 ⌋ times.
            You may assume that the array is non-empty and the majority element always exist in the array.
         */
        public int MajorityElementFunc(int[] nums)
        {
            Dictionary<int, int> counters = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                if (counters.ContainsKey(nums[i]))
                {
                    counters[nums[i]]++;
                }

                else
                {
                    counters.Add(nums[i], 1);
                }
            }

            foreach (var item in counters)
            {
                if (item.Value > nums.Length / 2)
                {
                    return item.Key;
                }
            }

            return -1;

        }
    }
}
