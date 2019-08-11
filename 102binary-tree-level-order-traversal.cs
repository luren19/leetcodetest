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
    public IList<IList<int>> LevelOrder(TreeNode root) {        
        var result = new List<IList<int>>();
        LevelMaker(root,result,0);
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
        //Console.WriteLine($"second:{list.Count},{level},{root.val}");
        list[level].Add(root.val);
        
        LevelMaker(root.left,list,level+1);
        LevelMaker(root.right,list,level+1);
                
    }
}
