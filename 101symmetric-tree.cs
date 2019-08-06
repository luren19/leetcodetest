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
    public bool IsSymmetric(TreeNode root) {
        if(root == null)
        {
            return true;
        }
        return IsSame(root.left,root.right);
    }
    
    public bool IsSame(TreeNode left, TreeNode right)
    {
        if(left == null && right == null)
        {
            return true;
        }
        if(left == null || right == null)
        {
            return false;
        }
        return (left.val == right.val) && IsSame(left.left,right.right) && IsSame(left.right,right.left);
    }
    
    public bool IsSymmetric-useiteration(TreeNode root) {
        Queue q = new Queue(); 
        q.Enqueue(root);
        q.Enqueue(root);
        while(q.Count!=0)
        {
            TreeNode q1 = (TreeNode)q.Dequeue();
            TreeNode q2 = (TreeNode)q.Dequeue();
            if(q1==null && q2==null)
            {
                continue;
            }
            if(q1==null || q2==null)
            {
                return false;
            }
            if(q1.val!=q2.val)
            {
                return false;
            }
            q.Enqueue(q1.left);
            q.Enqueue(q2.right);
            q.Enqueue(q1.right);
            q.Enqueue(q2.left);
        }
        return true;
    }
}
