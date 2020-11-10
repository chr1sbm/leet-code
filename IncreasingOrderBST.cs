using System;
using System.Collections.Generic;
using System.Text;
using Common;

namespace Solutions
{
    public class IncreasingOrderBST
    {
        /* 897. Increasing Order Search Tree https://leetcode.com/problems/increasing-order-search-tree/
         * Given a binary search tree, rearrange the tree in in-order so that the leftmost node
         * in the tree is now the root of the tree,
         * and every node has no left child and only 1 right child.
         */
        public TreeNode IncreasingBST(TreeNode root)
        {
            List<int> values = new List<int>();
            TraverseInOrder(root, values);
            return CreateTree(values);

        }

        private TreeNode CreateTree(List<int> values)
        {

            if (values.Count == 0) return null;

            TreeNode result = new TreeNode(values[0]);
            TreeNode temp = result;

            for (var i = 1; i < values.Count; i++)
            {
                temp.right = new TreeNode(values[i]);
                temp = temp.right;

            }

            return result;

        }

        private void TraverseInOrder(TreeNode root, List<int> values)
        {
            if (root != null)
            {
                if (root.left != null)
                {
                    TraverseInOrder(root.left, values);
                }

                values.Add(root.val);

                if (root.right != null)
                {
                    TraverseInOrder(root.right, values);
                }
            }

        }
    }
}
