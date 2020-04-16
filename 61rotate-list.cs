/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode RotateRight(ListNode head, int k) {
        if(head == null) return head;
        if(k == 0) return head;
        int count = 1;
        ListNode start = head;
        while(head.next != null){
            head = head.next;
            count++;
        }
        head.next = start;
        count = count - k % count;
        while(count > 0){
            head = head.next;
            count--;
        }
        start = head.next;
        head.next = null;
        return start;        
    }
}
