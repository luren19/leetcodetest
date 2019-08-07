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
    
    public bool IsBalanced-dfs(TreeNode root) {
        return dfsHeight(root)!=-1;
    }
    
    public int dfsHeight(TreeNode root)
    {
        if(root == null)
        {
            return 0;
        }
        int left = dfsHeight(root.left);
        if(left == -1)
        {
            return -1;
        }
        int right = dfsHeight(root.right);
        if(right == -1)
        {
            return -1;
        }
        if(Math.Abs(left-right)>1)
        {
            return -1;
        }
        
        return Math.Max(left,right)+1;
    }
}
