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
    
    public IList<string> BinaryTreePaths-usesb(TreeNode root) {
        IList<string> result = new List<string>();
        if(root!=null)
        {
            StringBuilder sb = new StringBuilder();
            searchRoot2Leaf-usesb(result,sb,root);
        }
        return result;
    }
    
    public void searchRoot2Leaf-usesb(IList<string> result, StringBuilder path, TreeNode root)
    {
        int len1 = path.Length;
        path.Append(root.val);
        if(root.left == null && root.right == null)
        {
            result.Add(path.ToString());
        }
        path.Append("->");
        int len2 = path.Length;
        if(root.left!=null)
        {            
            searchRoot2Leaf(result,path,root.left);
        }
        if(root.right!=null)
        {
            searchRoot2Leaf(result,path,root.right);
        }
        path.Remove(len1,len2-len1);
    }
}
