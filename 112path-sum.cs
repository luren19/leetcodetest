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
    public bool HasPathSum(TreeNode root, int sum) {
        if(root==null)
        {
            return false;
        }
        return CheckSum(root,sum,0);
    }
    
    public bool CheckSum(TreeNode root, int expect, int currentSum) 
    {
        if(root == null)
        {
            return expect == currentSum;
        }        
        if(root.left == null && root.right == null)
        {
            return expect == currentSum + root.val;
        }
        if(root.left == null)
        {
            return CheckSum(root.right,expect,currentSum+root.val);
        }
        if(root.right == null)
        {
            return CheckSum(root.left,expect,currentSum+root.val);
        }
        return CheckSum(root.left,expect,currentSum+root.val) || CheckSum(root.right,expect,currentSum+root.val);
    }
}
