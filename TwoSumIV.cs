using System;
using System.Collections.Generic;
using Common;

namespace Solutions
{
    /*  653. Two Sum IV - Input is a BST https://leetcode.com/problems/two-sum-iv-input-is-a-bst/
        Given the root of a Binary Search Tree and a target number k,
        return true if there exist two elements in the BST such that their sum is equal to the given target.
 
     */
    public class TwoSumIV
    {
        public bool FindTarget(TreeNode root, int k)
        {
            List<int> values = new List<int>();
            traverseBST(root, values);

            for (var i = 0; i < values.Count; i++)
            {
                var rest = k - values[i];
                if (values.IndexOf(rest) != -1 && rest != values[i]) return true;
            }

            return false;

        }

        private void traverseBST(TreeNode root, List<int> values)
        {
            if (root != null)
            {
                traverseBST(root.left, values);
                values.Add(root.val);
                traverseBST(root.right, values);
            }
        }
    }
}
