using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions.HashMap
{
    public class NumberGoodPairs
    {
        /*  1512. Number of Good Pairs https://leetcode.com/problems/number-of-good-pairs/
            Given an array of integers nums.
            A pair (i,j) is called good if nums[i] == nums[j] and i < j.
            Return the number of good pairs.
        */
        public int NumIdenticalPairs(int[] nums)
        {
            // since nums[i] <= 100
            int[] counters = new int[101];
            int result = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                counters[nums[i]]++;
            }

            foreach (int val in counters)
            {
                if (val > 0)
                {
                    result += val * (val - 1) / 2;
                }

            }

            return result;

        }
    }
}
