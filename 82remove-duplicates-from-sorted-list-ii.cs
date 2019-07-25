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
        ListNode fakeHead = new ListNode(0);
        ListNode preNode = fakeHead;
        fakeHead.next = head;
        while(head!=null)
        {
            while(head.next!=null&&head.val==head.next.val)
            {
                head = head.next;
            }
            if(preNode.next==head)
            {
                preNode = preNode.next;
            }
            else
            {
                preNode.next = head.next;
            }
            head = head.next;
        }
        return fakeHead.next;
    }
    
    public ListNode DeleteDuplicates-recursive(ListNode head) {
        //if current node is not unique, return deleteDuplicates with head.next.
        //If current node is unique, link it to the result of next list made by recursive call. 

        if(head == null)
        {
            return null;
        }
        if(head.next !=null && head.val == head.next.val)
        {
            while(head.next !=null && head.val == head.next.val)
            {
                head = head.next;
            }
            return DeleteDuplicates(head.next);
        }
        else
        {
            head.next = DeleteDuplicates(head.next);
        }
        return head;
    }
}
