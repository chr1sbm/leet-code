using System;
using System.Collections.Generic;
using System.Text;
using Common;

namespace Solutions
{
    /*
        404. Sum of Left Leaves https://leetcode.com/problems/sum-of-left-leaves/
        Find the sum of all left leaves in a given binary tree.
        Example:

            3
           / \
          9  20
            /  \
           15   7

        There are two left leaves in the binary tree, with values 9 and 15 respectively. Return 24.
         */
    public class SumOfLeftLeaves
    {
        public int SumLeftLeaves(TreeNode root, bool isLeft = false)
        {
            if (root == null) return 0;

            else if (root.left == null && root.right == null && isLeft)
            {
                return root.val;
            }

            else
            {
                return SumLeftLeaves(root.left, true) + SumLeftLeaves(root.right);
            }

        }
    }
}
