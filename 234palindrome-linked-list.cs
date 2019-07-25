/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public bool IsPalindrome(ListNode head) {
        ListNode fast = head;
        ListNode slow = head;
        while(fast!=null && fast.next!=null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }
        if(fast!=null)
        {
            slow = slow.next;//make the reverse part smaller than a half;
        }
        slow = ReverseList(slow);
        fast = head;
        while(slow!=null)
        {
            if(slow.val!=fast.val)
            {
                return false;
            }
            slow = slow.next;
            fast = fast.next;
        }
        return true;
    }
    
    public ListNode ReverseList(ListNode head)
    {
        ListNode preNode = null;
        ListNode nxtNode = head;
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
