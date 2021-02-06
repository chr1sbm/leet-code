using Common;

namespace Solutions
{
    public class TrimBinarySearchTree
    {
        /* https://leetcode.com/problems/trim-a-binary-search-tree/ */
        public TreeNode TrimBST(TreeNode root, int low, int high)
        {

            if (root == null) return null;

            if (root.val > high)
            {
                return TrimBST(root.left, low, high);
            }

            if (root.val < low)
            {
                return TrimBST(root.right, low, high);
            }

            root.left = TrimBST(root.left, low, high);
            root.right = TrimBST(root.right, low, high);

            return root;

        }
    }
}
