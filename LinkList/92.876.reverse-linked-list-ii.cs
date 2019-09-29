/*
 * @lc app=leetcode id=92 lang=csharp
 * [92] Reverse Linked List II
 * https://leetcode.com/problems/reverse-linked-list-ii/description/
 *
 * Testcase Example:  '[1,2,3,4,5]\n2\n4'
 *
 * Reverse a linked list from position m to n. Do it in one-pass.
 * 
 * Note: 1 ≤ m ≤ n ≤ length of list.
 * 
 * Example:
 * Input: 1->2->3->4->5->NULL, m = 2, n = 4
 * Output: 1->4->3->2->5->NULL
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode ReverseBetween(ListNode head, int m, int n) {
        if(head == null){
            return head;
        }
        ListNode dummy = new ListNode(0);
        dummy.next = head;
        ListNode MNode = head, NNode = head;
        ListNode preM = dummy;
        for(int i = 1; i < m; i++){
            preM = preM.next;
            MNode = MNode.next;
        }
        for(int i = 1; i < n; i++){
            NNode = NNode.next;
        }
        while(MNode != NNode){
            preM.next = MNode.next;
            MNode.next = NNode.next;
            NNode.next = MNode;
            MNode = preM.next;
        }
        return dummy.next;
    }

/*
876. Middle of the Linked List
Given a non-empty, singly linked list with head node head, return a middle node of linked list.

If there are two middle nodes, return the second middle node.
Example 1:

Input: [1,2,3,4,5]
Output: Node 3 from this list (Serialization: [3,4,5])
The returned node has value 3.  (The judge's serialization of this node is [3,4,5]).
Note that we returned a ListNode object ans, such that:
ans.val = 3, ans.next.val = 4, ans.next.next.val = 5, and ans.next.next.next = NULL.
Example 2:

Input: [1,2,3,4,5,6]
Output: Node 4 from this list (Serialization: [4,5,6])
Since the list has two middle nodes with values 3 and 4, we return the second one.
 */
      public ListNode MiddleNode876(ListNode head) {
        ListNode slow = head, fast = head;
        while(fast != null && fast.next != null){
            slow = slow.next;
            fast = fast.next.next;
        }
        return slow;
    }
}

