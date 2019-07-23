/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        ListNode result = head;
        while(head!=null)
        {
            if(head.next!=null && head.val==head.next.val)
            {
                head.next = head.next.next;
            }
            else
            {
                head = head.next;
            }            
        }
        return result;
    }
}
