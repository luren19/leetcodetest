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
    public bool IsSameTree(TreeNode p, TreeNode q) {
        // p and q are null
        if(p==null && q==null)
        {
            return true;
        }
        // one of p and q is null
        if(p==null || q==null)
        {
            return false;
        }
        if(p.val != q.val)
        {
            return false;
        }
        return (IsSameTree(p.left,q.left)&&IsSameTree(p.right,q.right));        
    }
}
