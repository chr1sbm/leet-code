using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions.Arrays
{
    public class RunningSum1DArray
    { /*1480. Running Sum of 1d Array https://leetcode.com/problems/running-sum-of-1d-array/
        Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).
        Return the running sum of nums.
         */
        public int[] RunningSum(int[] nums)
        {
            int length = nums.Length;
            int sum = 0;
            int index = 0;

            for (var i = 0; i < length; i++)
            {
                sum += nums[i];
                nums[i] = sum;
                index++;
            }

            return nums;

        }
    }
}
