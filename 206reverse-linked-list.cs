/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode ReverseList-r(ListNode head) {
        if(head!=null && head.next!=null)
        {
            ListNode temp = ReverseList(head.next);
            head.next.next = head;
            head.next = null;
            return temp;
        }
        else
        {
            return head;
        } 
    }
    
    public ListNode ReverseList-i(ListNode head) {
        ListNode preNode = null;
        ListNode nxtNode = null;
        while(head!=null)
        {
            nxtNode = head.next;
            head.next = preNode;
            preNode = head;
            head = nxtNode;            
        }
        return preNode; 
    }

}
