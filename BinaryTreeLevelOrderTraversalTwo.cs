using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solutions
{
    /*
     *  107. Binary Tree Level Order Traversal II https://leetcode.com/problems/binary-tree-level-order-traversal-ii/
        Given a binary tree, return the bottom-up level order traversal of its nodes' values. (ie, from left to right, level by level from leaf to root).

        For example:
        Given binary tree [3,9,20,null,null,15,7],
            3
           / \
          9  20
            /  \
           15   7
        
        TIP: Pay attention to cases of nodes with only one child on different positions (left/right)
    */
    public class BinaryTreeLevelOrderTraversalTwo
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
        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (root == null) return result;
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);

            while (q.Count > 0)
            {
                List<int> children = new List<int>();
                int qSize = q.Count;

                for (var i = 0; i < qSize; i++)
                {
                    var temp = q.Dequeue();
                    children.Add(temp.val);

                    if (temp.left != null)
                    {
                        q.Enqueue(temp.left);
                    }

                    if (temp.right != null)
                    {
                        q.Enqueue(temp.right);
                    }
                }

                result.Add(children);

            }

            return result.Reverse().ToList();
        }
    }
}
