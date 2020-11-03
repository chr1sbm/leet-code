using System;
using System.Collections.Generic;
using System.Text;
using Common;

namespace Solutions
{
    public class SearchInBST
    {
        /*
         *  700. Search in a Binary Search Tree https://leetcode.com/problems/search-in-a-binary-search-tree/
            Given the root node of a binary search tree (BST) and a value.
            You need to find the node in the BST that the node's value equals the given value.
            Return the subtree rooted with that node. If such node doesn't exist, you should return NULL.
            For example, 
            Given the tree:
                    4
                   / \
                  2   7
                 / \
                1   3

            And the value to search: 2

            NOTE: Consider special treatment for Binary Search Tree
             */
        public TreeNode SearchBST(TreeNode root, int val)
        {
            if (root == null) return null;
            else if (root.val == val) return root;
            if (val > root.val) return SearchBST(root.right, val);
            else return SearchBST(root.left, val);
        }
    }
}
