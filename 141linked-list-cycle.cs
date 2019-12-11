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
    // To detect if a list is cyclic, we can check whether a node had been visited before. A natural way is to use a hash table.
    public bool HasCycle(ListNode head) {
        Hashtable nodevisit = new Hashtable();
        while(head != null){
            if(nodevisit.ContainsKey(head)){
                return true;
            }
            else{
                nodevisit.Add(head,"");
            }
            head = head.next;
        }
        return false;
    }
    
    //Imagine two runners running on a track at different speed. What happens when the track is actually a circle?
    public bool HasCycle(ListNode head) {
        ListNode slow = head;
        ListNode fast = head;
        while(fast != null && fast.next !=null){
            fast = fast.next.next;
            slow = slow.next;
            if(fast == slow){
                return true;
            }
        }
        return false;
    }
}
