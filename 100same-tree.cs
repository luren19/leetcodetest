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
    
    public bool IsSameTree-BFS(TreeNode p, TreeNode q) {
        Queue pQueue = new Queue(); 
        Queue qQueue = new Queue();

        pQueue.Enqueue(p);
        qQueue.Enqueue(q);
        
        while(pQueue.Count!=0 && qQueue.Count!=0)
        {
            p=(TreeNode)pQueue.Dequeue();
            q=(TreeNode)qQueue.Dequeue();
            if(p==null&&q==null)
            {
                continue;
            }
            if(p==null||q==null)
            {
                return false;
            }
            if(p.val!=q.val)
            {
                return false;
            }
            pQueue.Enqueue(p.left);
            pQueue.Enqueue(p.right);
            qQueue.Enqueue(q.left);
            qQueue.Enqueue(q.right);
        }
        
        return true;
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
