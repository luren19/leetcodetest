/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    //Use hash table
    public ListNode DetectCycle(ListNode head) {
        Hashtable nodevisit = new Hashtable();
        while(head != null){
            if(nodevisit.ContainsKey(head)){
                return head;
            }
            else{
                nodevisit.Add(head,"");
            }
            head = head.next;
        }
        return null;
    }
    
    //Floyd's Tortoise and Hare
    public ListNode DetectCycle(ListNode head) {
        ListNode slow = head;
        ListNode fast = head;
        ListNode meet = head;
        Boolean isCycle = false;
        while(fast != null && fast.next !=null){
            fast = fast.next.next;
            slow = slow.next;
            if(fast == slow){
                isCycle = true;
                break;
            }
        }
        
        if(!isCycle){
            return null;
        }
        slow = head;
        while(slow != fast){
            slow = slow.next;
            fast = fast.next;
        }
        return slow;
    }
}
