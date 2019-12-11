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
}
