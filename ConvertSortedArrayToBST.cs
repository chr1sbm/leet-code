using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;

namespace Solutions
{
    /*
     * Given an array where elements are sorted in ascending order, convert it to a height balanced BST.
       For this problem, a height-balanced binary tree is defined as a binary tree in which the depth of the two
       subtrees of every node never differ by more than 1.
       108. Convert Sorted Array to Binary Search Tree https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree/
       TIP: Look for a good mid value that will separate the array in almost half (not strictly) to have the tree balanced
     */
    public class ConvertSortedArrayToBST
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            return CreateTreeRecursively(nums, 0, nums.Length - 1);
        }

        public TreeNode CreateTreeRecursively(int[] nums, int leftIndex, int rightIndex)
        {
            if (leftIndex > rightIndex) return null;
            int midIndex = (rightIndex + leftIndex) / 2;
            TreeNode node = new TreeNode(nums[midIndex]);
            node.left = CreateTreeRecursively(nums, leftIndex, midIndex - 1);
            node.right = CreateTreeRecursively(nums, midIndex + 1, rightIndex);
            return node;

        }
    }
}
