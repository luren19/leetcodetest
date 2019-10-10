/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
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
    public TreeNode SortedListToBST(ListNode head) {
        if(head == null)
        {
            return null;
        }
        ListNode mid = GetBSTRoot(head);
        TreeNode node = new TreeNode(mid.val);
        
        // Base case when there is just one element in the linked list
        if(head == mid)
        {
            return node;
        }
        node.left = SortedListToBST(head);
        node.right = SortedListToBST(mid.next);
        
        return node;
    }
    
    private ListNode GetBSTRoot(ListNode head)
    {
        ListNode prevPtr = null;
        ListNode slowPtr = head;
        ListNode fastPtr = head;
        
        while(fastPtr != null && fastPtr.next != null)
        {
            prevPtr = slowPtr;
            slowPtr = slowPtr.next;
            fastPtr = fastPtr.next.next;
        }
        if(prevPtr != null)
        {
            prevPtr.next = null;
        }
        return slowPtr;
    }
}
