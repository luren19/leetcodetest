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
    public IList<string> BinaryTreePaths(TreeNode root) {
        IList<string> result = new List<string>();
        if(root!=null)
        {
            searchRoot2Leaf(result,"",root);
        }
        return result;
    }
    
    public void searchRoot2Leaf(IList<string> result, string path, TreeNode root)
    {
        if(root.left == null && root.right == null)
        {
            result.Add(path+root.val);
        }
        if(root.left!=null)
        {
            searchRoot2Leaf(result,path+root.val+"->",root.left);
        }
        if(root.right!=null)
        {
            searchRoot2Leaf(result,path+root.val+"->",root.right);
        }
    }
}
