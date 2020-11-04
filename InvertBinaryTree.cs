using System;
using System.Collections.Generic;
using System.Text;
using Common;

namespace Solutions
{   /*  226. Invert Binary Tree https://leetcode.com/problems/invert-binary-tree/
        Invert a binary tree.
        Example:
        Input:

             4
           /   \
          2     7
         / \   / \
        1   3 6   9
        Output:

             4
           /   \
          7     2
         / \   / \
        9   6 3   1
     */
    public class InvertBinaryTree
    {   
        // Recursive-style solution
        public TreeNode InvertTreeRecursive(TreeNode root)
        {
            if (root == null) return null;
            TreeNode left = InvertTreeRecursive(root.left);
            TreeNode right = InvertTreeRecursive(root.right);
            root.left = right;
            root.right = left;
            return root;
        }


        // Iterative-style solution
        public TreeNode InvertTreeIteratively(TreeNode root)
        {
            if (root == null) return null;
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);

            while (q.Count > 0)
            {
                var current = q.Dequeue();
                var aux = current.left;
                current.left = current.right;
                current.right = aux;
                if (current.left != null) q.Enqueue(current.left);
                if (current.right != null) q.Enqueue(current.right);
            }

            return root;

        }
    }
}
