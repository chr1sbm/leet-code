using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions
{
    /*
     *  Given a binary tree, determine if it is height-balanced.

        For this problem, a height-balanced binary tree is defined as:

        a binary tree in which the left and right subtrees of every node differ in height by no more than 1.

        Problem 110. Balanced Binary Tree https://leetcode.com/problems/balanced-binary-tree/
     */
    public class BalancedBinaryTree
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
        public bool IsBalanced(TreeNode root)
        {
            if (root == null) return true;
            int height = getHeight(root);
            return height > 0;

        }
        private int getHeight(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }

            int left = getHeight(node.left);
            int right = getHeight(node.right);

            if (left == -1 || right == -1 || Math.Abs(left - right) > 1)
            {
                return -1;
            }

            return Math.Max(left, right) + 1;

        }
    }
}
