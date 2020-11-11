using System;
using System.Collections.Generic;
using System.Linq;
using Common;

namespace Solutions
{
    public class RangeOfSumBST
    {
        /*  938. Range Sum of BST https://leetcode.com/problems/range-sum-of-bst/
            Given the root node of a binary search tree, return the sum of values of all nodes with a value in the range [low, high].
             */
        public int RangeSumBST(TreeNode root, int low, int high)
        {
            List<int> values = new List<int>();
            TraverseTree(root, low, high, values);
            return values.Sum();
        }

        private void TraverseTree(TreeNode root, int low, int high, List<int> values)
        {
            if (root != null)
            {
                TraverseTree(root.left, low, high, values);
                if (root.val >= low && root.val <= high) values.Add(root.val);
                TraverseTree(root.right, low, high, values);
            }
        }
    }
}
