using Common;
using System.Collections.Generic;

namespace Solutions
{
    /*
        965. Univalued Binary Tree https://leetcode.com/problems/univalued-binary-tree/
        A binary tree is univalued if every node in the tree has the same value.
        Return true if and only if the given tree is univalued.
         */
    public class UnivaluedBinaryTree
    {
        /* Recursive solution */
        public bool IsUnivalTree(TreeNode root)
        {
            if (root == null) return true;

            if (root.left != null)
            {
                if (root.left.val != root.val)
                {
                    return false;
                }

            }

            if (root.right != null)
            {
                if (root.right.val != root.val)
                {
                    return false;
                }

            }

            return IsUnivalTree(root.left) && IsUnivalTree(root.right);

        }

        /* Iterative solution */
        public bool IsUnivalTree2(TreeNode root)
        {
            int tree_val = root.val;
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                var temp = q.Dequeue();

                if (temp.left != null)
                {
                    if (temp.left.val != tree_val) return false;
                    q.Enqueue(temp.left);
                }

                if (temp.right != null)
                {
                    if (temp.right.val != tree_val) return false;
                    q.Enqueue(temp.right);
                }

            }

            return true;
        }
    }
}
