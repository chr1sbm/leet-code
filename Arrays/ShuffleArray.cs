using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions.Arrays
{
    /*  1470. Shuffle the Array https://leetcode.com/problems/shuffle-the-array/
        Given the array nums consisting of 2n elements in the form [x1,x2,...,xn,y1,y2,...,yn].
        Return the array in the form [x1,y1,x2,y2,...,xn,yn].
         */
    public class ShuffleArray
    {
        public int[] Shuffle(int[] nums, int n)
        {
            int[] result = new int[2 * n];

            for (var i = 0; i < n; i++)
            {
                result[2 * i] = nums[i];
                result[2 * i + 1] = nums[n + i];
            }

            return result;

        }
    }
}
