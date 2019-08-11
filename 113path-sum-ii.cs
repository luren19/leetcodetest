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
    public IList<IList<int>> PathSum(TreeNode root, int sum) {
        var result = new List<IList<int>>();
        CheckPathSum(result,new List<int>(),root,sum);
        return result;
    }
    
    public void CheckPathSum(List<IList<int>> result, List<int> subList, TreeNode root, int sum)
    {
        if(root == null)
        {
            return;
        }
        subList.Add(root.val);
        if(root.left == null && root.right == null && sum == root.val)
        {            
            result.Add(new List<int>(subList));
            subList.RemoveAt(subList.Count-1);
            return;
        }
        sum = sum - root.val;
        CheckPathSum(result,subList,root.left,sum);
        CheckPathSum(result,subList,root.right,sum);
        
        subList.RemoveAt(subList.Count-1);
        return;
    }
}
