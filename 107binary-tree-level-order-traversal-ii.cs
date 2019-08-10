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
    
    public IList<IList<int>> LevelOrderBottom-recurse(TreeNode root) {        
        var result = new List<IList<int>>();
        LevelMaker(root,result,0);
        result.Reverse();
        return result;
    }
    public void LevelMaker(TreeNode root, List<IList<int>> list, int level)
    {
        //Console.WriteLine($"{list.Count},{level}");
        if(root == null)
        {
            return;
        }
        //Console.WriteLine($"first:{list.Count},{level},{root.val}");
        if(level >= list.Count)
        {
            list.Add(new List<int>());
        }
        LevelMaker(root.left,list,level+1);
        LevelMaker(root.right,list,level+1);
        
        //Console.WriteLine($"second:{list.Count},{level},{root.val}");
        list[level].Add(root.val);
    }
}
