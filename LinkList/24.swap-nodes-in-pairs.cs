/*
 * @lc app=leetcode id=24 lang=csharp
 *
 * [24] Swap Nodes in Pairs
 *
 * https://leetcode.com/problems/swap-nodes-in-pairs/description/
 *
 * algorithms
 * Medium (45.67%)
 * Likes:    1278
 * Dislikes: 112
 * Total Accepted:    338.1K
 * Total Submissions: 740.3K
 * Testcase Example:  '[1,2,3,4]'
 *
 * Given a linked list, swap every two adjacent nodes and return its head.
 * 
 * You may not modify the values in the list's nodes, only nodes itself may be
 * changed.
 * 
 * 
 * 
 * Example:
 * 
 * 
 * Given 1->2->3->4, you should return the list as 2->1->4->3.
 * 
 * 
 */
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode SwapPairs(ListNode head) {
        ListNode dummy = new ListNode(0);
        dummy.next = head;
        ListNode cur = dummy;
        while(cur.next != null && cur.next.next != null){
            /*swap */
            ListNode tmp = cur.next;
            cur.next = tmp.next;
            tmp.next = tmp.next.next;
            cur.next.next = tmp;
            /*swap */
            cur = cur.next.next;
        }
        return dummy.next;
    }

    public ListNode SwapPairs1(ListNode head) {
        ListNode dummy = new ListNode(0);
        dummy.next = head;
        ListNode cur = dummy;
        while(cur.next != null && cur.next.next != null){
            ListNode first = cur.next;
            ListNode second = cur.next.next;
            first.next = second.next;
            cur.next =  second;
            second.next = first;
            cur = first;
        }
        return dummy.next;
    }
}

