/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public bool IsBalanced(TreeNode root) {
        if(root==null)
        {
            return true;
        }
        int left = depth(root.left);
        int right = depth(root.right);
        return Math.Abs(left-right)<=1 && IsBalanced(root.left) && IsBalanced(root.right);
    }
    
    public int depth(TreeNode root)
    {
        if(root == null)
        {
            return 0;
        }
        return Math.Max(depth(root.left),depth(root.right))+1;
    }
}
