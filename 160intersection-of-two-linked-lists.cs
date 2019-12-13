/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    //Brute force
    //For each node ai in list A, traverse the entire list B and check if any node in list B coincides with ai.
    //Complexity Analysis
    //Time complexity : O(mn)O(mn).
    //Space complexity : O(1)O(1).
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
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
}
