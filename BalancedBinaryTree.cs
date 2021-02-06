using System;
using System.Collections.Generic;
using System.Text;
using Common;

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

        public bool IsBalancedV2(TreeNode root)
        {
            bool isBalanced = true;
            getHeightV2(root, ref isBalanced);
            return isBalanced;
        }

        private int getHeightV2(TreeNode root, ref bool isBalanced)
        {
            if (root == null) return 0;

            var left = getHeightV2(root.left, ref isBalanced);
            var right = getHeightV2(root.right, ref isBalanced);

            if (Math.Abs(left - right) > 1) isBalanced = false;

            return Math.Max(left, right) + 1;

        }
    }
}
