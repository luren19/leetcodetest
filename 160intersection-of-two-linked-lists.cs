/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    /*Approach 1: Brute Force
    For each node ai in list A, traverse the entire list B and check if any node in list B coincides with ai.

    Complexity Analysis

    Time complexity : O(mn).

    Space complexity : O(1).*/
    public ListNode GetIntersectionNode1(ListNode headA, ListNode headB) {
        while(headA != null){
            ListNode check = headB;
            while(check != null){
                //Console.WriteLine(headA.val + " " + check.val);
                if(headA == check){
                    return headA;
                }
                check = check.next;
            }
            headA = headA.next;
        }
        return null;
    }
    /*Approach 2: Hash Table
    Traverse list A and store the address / reference to each node in a hash set. Then check every node bi in list B: if bi appears in the hash set, then bi is the intersection node.

    Complexity Analysis

    Time complexity : O(m+n).

    Space complexity : O(m) or O(n).*/
    public ListNode GetIntersectionNode2(ListNode headA, ListNode headB) {
        Hashtable nodeList = new Hashtable();
        while(headA != null){
            nodeList.Add(headA, "");
            headA = headA.next;
        }
        while(headB != null){
            if(nodeList.ContainsKey(headB)){
                return headB;
            }
            headB = headB.next;
        }
        return null;
    }
    
    /*
    Approach 3: Two Pointers
    Maintain two pointers pApA and pBpB initialized at the head of A and B, respectively. Then let them both traverse through the lists, one node at a time.
    When pApA reaches the end of a list, then redirect it to the head of B (yes, B, that's right.); similarly when pBpB reaches the end of a list, redirect it the head of A.
    If at any point pApA meets pBpB, then pApA/pBpB is the intersection node.
    To see why the above trick would work, consider the following two lists: A = {1,3,5,7,9,11} and B = {2,4,9,11}, which are intersected at node '9'. Since B.length (=4) < A.length (=6), pBpB would reach the end of the merged list first, because pBpB traverses exactly 2 nodes less than pApA does. By redirecting pBpB to head A, and pApA to head B, we now ask pBpB to travel exactly 2 more nodes than pApA would. So in the second iteration, they are guaranteed to reach the intersection node at the same time.
    If two lists have intersection, then their last nodes must be the same one. So when pApA/pBpB reaches the end of a list, record the last element of A/B respectively. If the two last elements are not the same one, then the two lists have no intersections.
    Complexity Analysis

    Time complexity : O(m+n)O(m+n).

    Space complexity : O(1)O(1).
    */
    public ListNode GetIntersectionNode3(ListNode headA, ListNode headB) {
        ListNode ptA = headA;
        ListNode ptB = headB;
        while(ptA != ptB){
            ptA = ptA == null ? headB : ptA.next;
            ptB = ptB == null ? headA : ptB.next;
        }
        return ptA;
    }
}
