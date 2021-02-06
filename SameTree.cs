using Common;

namespace Solutions
{
    public class SameTree
    {
        /* https://leetcode.com/problems/same-tree/ */
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null) return true;
            if (p == null || q == null) return false;

            bool checkLeft = false;
            bool checkRight = false;

            if (p.val == q.val)
            {
                checkLeft = IsSameTree(p.left, q.left);
                checkRight = IsSameTree(p.right, q.right);
            }

            return checkLeft && checkRight;
        }
    }
}
