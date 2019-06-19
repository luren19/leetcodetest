/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists1(ListNode l1, ListNode l2) {
        if(l1 == null)
        {
            return l2;
        }
        if(l2 == null)
        {
            return l1;
        }
            
        ListNode result;
        ListNode temp;
        if(l1.val <= l2.val)
        {
            result = l1;
            l1 = l1.next;
        }
        else
        {
            result = l2;
            l2 = l2.next;
            
        }
        temp = result;
        while(l1 != null && l2 != null)
        {
            if(l1.val <= l2.val)
            {
                temp.next = l1;
                l1 = l1.next;
            }
            else
            {
                temp.next = l2;
                l2 = l2.next;
            }
            temp = temp.next;
        }
        
        if(l1 != null)
        {
            temp.next = l1;
        }
        if(l2 != null)
        {
            temp.next = l2;
        }

        return result;
        
    }
    public ListNode MergeTwoLists2(ListNode l1, ListNode l2) {
        if(l1 == null)
        {
            return l2;
        }
        if(l2 == null)
        {
            return l1;
        }
            
        ListNode result = (l1.val <= l2.val)?l1:l2;
        ListNode temp = (l1.val <= l2.val)?l2:l1;
        result.next = MergeTwoLists(result.next,temp);

        return result;
        
    }
}
