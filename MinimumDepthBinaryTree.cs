using System;
using System.Collections.Generic;
using System.Text;
using Common;


namespace Solutions
{
    public class MinimumDepthBinaryTree
    {
        /*  111. Minimum Depth of Binary Tree https://leetcode.com/problems/minimum-depth-of-binary-tree/
         *  Given a binary tree, find its minimum depth.
            The minimum depth is the number of nodes along the shortest path from the root node down to the nearest leaf node.
            NOTE: THIS IS BFS METHOD, IT'S ALSO POSSIBLE USING DFS
             */
        
        public int MinDepth(TreeNode root)
        {
            if (root == null) return 0;
            Queue<TreeNode> nodes = new Queue<TreeNode>();
            int currentLevel = 0;
            nodes.Enqueue(root);

            while (nodes.Count > 0)
            {
                currentLevel++;
                int qSize = nodes.Count;

                for (var i = 0; i < qSize; i++)
                {
                    var temp = nodes.Dequeue();

                    if (temp.left == null && temp.right == null)
                    {
                        return currentLevel;
                    }

                    if (temp.left != null)
                    {
                        nodes.Enqueue(temp.left);

                    }

                    if (temp.right != null)
                    {
                        nodes.Enqueue(temp.right);

                    }

                }

            }

            return currentLevel;
        }
    }
}
