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
    public IList<IList<int>> LevelOrderBottom(TreeNode root) {        
        var result = new List<IList<int>>();
        if(root == null)
        {
            return result;
        }        
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while(queue.Count !=0)
        {
            int levelNum = queue.Count;
            List<int> subList = new List<int>();
            for(int i = 0; i < levelNum; i++)
            {
                TreeNode current = queue.Dequeue();
                if(current.left!=null)
                {
                    queue.Enqueue(current.left);
                }
                if(current.right!=null)
                {
                    queue.Enqueue(current.right);
                }
                subList.Add(current.val);
            }
            result.Add(subList);
        }
        result.Reverse();
        return result;
    }
}
