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
}
