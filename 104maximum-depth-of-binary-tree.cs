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
    public int MaxDepth(TreeNode root) {
        return MaxDepth(root, 0);
    }
    
    public int MaxDepth(TreeNode current,int depth)
    {
        if(current==null)
        {
            return depth;
        }
        depth++;
        int leftDepth = MaxDepth(current.left,depth);
        int rightDepth = MaxDepth(current.right,depth);
        depth = leftDepth>rightDepth?leftDepth:rightDepth;
        return depth;
    }
}
