using System;
using System.Collections.Generic;
using System.Text;
using Common;

namespace Solutions
{
    /*
        104. Maximum Depth of Binary Tree https://leetcode.com/problems/maximum-depth-of-binary-tree/
        Given a binary tree, find its maximum depth.
        The maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.
        Note: A leaf is a node with no children.
        Example:
        Given binary tree [3,9,20,null,null,15,7],

            3
           / \
          9  20
            /  \
           15   7
         */
    public class MaximumDepthBinaryTree
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;
            int left = MaxDepth(root.left);
            int right = MaxDepth(root.right);
            return Math.Max(left, right) + 1;

        }
    }
}
