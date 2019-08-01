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
}
