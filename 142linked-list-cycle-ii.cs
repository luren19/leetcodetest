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
}
