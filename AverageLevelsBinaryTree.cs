using System;
using System.Collections.Generic;
using Common;

namespace Solutions
{
    public class AverageLevelsBinaryTree
    {
        /* 637. Average of Levels in Binary Tree https://leetcode.com/problems/average-of-levels-in-binary-tree/
         * Given a non-empty binary tree, return the average value of the nodes on each level in the form of an array.
         */
        public IList<double> AverageOfLevels(TreeNode root)
        {
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            List<double> result = new List<double>();

            while (q.Count > 0)
            {
                double qSize = q.Count;
                double sum = 0;

                for (var i = 0; i < qSize; i++)
                {
                    TreeNode temp = q.Dequeue();
                    sum += temp.val;
                    if (temp.left != null)
                    {
                        q.Enqueue(temp.left);
                    }
                    if (temp.right != null)
                    {
                        q.Enqueue(temp.right);
                    }
                }

                result.Add(sum / qSize);
            }

            return result;

        }
    }
}
