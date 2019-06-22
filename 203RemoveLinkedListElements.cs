/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode RemoveElements(ListNode head, int val) {
        ListNode result = new ListNode(0);
        ListNode temp = result;
        /*while(head !=null && head.val ==val)
        {
            result = head.next;
            head = head.next;            
        }*/
        while(head !=null)
        {
            if(head.val!=val)
            {
                temp.next = head;
                temp = temp.next;
            }
            head = head.next;
        }
        temp.next = null;
        return result.next;        
    }
}
