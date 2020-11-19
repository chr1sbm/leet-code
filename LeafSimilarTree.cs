using System;
using System.Collections.Generic;
using Common;

namespace Solutions
{
    public class LeafSimilarTree
    {
        /*  872. Leaf-Similar Trees https://leetcode.com/problems/leaf-similar-trees/
            Consider all the leaves of a binary tree, from left to right order, the values of those leaves form a leaf value sequence.
            Two binary trees are considered leaf-similar if their leaf value sequence is the same.
            Return true if and only if the two given trees with head nodes root1 and root2 are leaf-similar.
             */
        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            List<int> firstLeaves = new List<int>();
            List<int> secondLeaves = new List<int>();
            findLeaves(root1, firstLeaves);
            findLeaves(root2, secondLeaves);

            if (firstLeaves.Count != secondLeaves.Count) return false;

            for (var i = 0; i < firstLeaves.Count; i++)
            {
                if (firstLeaves[i] != secondLeaves[i])
                {
                    return false;
                }
            }

            return true;


        }

        private void findLeaves(TreeNode root, List<int> list)
        {
            if (root.left == null && root.right == null)
            {
                list.Add(root.val);
            }

            if (root.left != null)
            {
                findLeaves(root.left, list);
            }

            if (root.right != null)
            {
                findLeaves(root.right, list);
            }

        }
    }
}
