/*
Given a linked list, rotate the list to the right by k places, where k is non-negative.

Example 1:

Input: 1->2->3->4->5->NULL, k = 2
Output: 4->5->1->2->3->NULL
Explanation:
rotate 1 steps to the right: 5->1->2->3->4->NULL
rotate 2 steps to the right: 4->5->1->2->3->NULL
Example 2:

Input: 0->1->2->NULL, k = 4
Output: 2->0->1->NULL
Explanation:
rotate 1 steps to the right: 2->0->1->NULL
rotate 2 steps to the right: 1->2->0->NULL
rotate 3 steps to the right: 0->1->2->NULL
rotate 4 steps to the right: 2->0->1->NULL
 */

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution
{
    public ListNode RotateRight(ListNode head, int k)
    {
        if (head == null || head.next == null) return head;
        ListNode p = head;
        int n = 1; //list count
        while (p.next != null)
        {
            p = p.next;
            n++;
        }
        //after this loop move, p moved to tail
        p.next = head;  //connect tail to head

        k %= n; //if K > list count, use k%count
        for (int i = 0; i < n - k; i++)
        {
            p = p.next; //move to K, 
        }
        head = p.next;
        p.next = null; //cut link to avoid circle
        p = head;
        return head; 
    }
}
