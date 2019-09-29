/*
 * @lc app=leetcode id=25 lang=csharp
 *
 * [25] Reverse Nodes in k-Group
 *
 * https://leetcode.com/problems/reverse-nodes-in-k-group/description/
 *
 * algorithms
 * Hard (37.30%)
 * Likes:    1302
 * Dislikes: 263
 * Total Accepted:    197.5K
 * Total Submissions: 528.6K
 * Testcase Example:  '[1,2,3,4,5]\n2'
 *
 * Given a linked list, reverse the nodes of a linked list k at a time and
 * return its modified list.
 * 
 * k is a positive integer and is less than or equal to the length of the
 * linked list. If the number of nodes is not a multiple of k then left-out
 * nodes in the end should remain as it is.
 * 
 * 
 * 
 * 
 * Example:
 * 
 * Given this linked list: 1->2->3->4->5
 * 
 * For k = 2, you should return: 2->1->4->3->5
 * 
 * For k = 3, you should return: 3->2->1->4->5
 * 
 * Note:
 * 
 * 
 * Only constant extra memory is allowed.
 * You may not alter the values in the list's nodes, only nodes itself may be
 * changed.
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
    public ListNode ReverseKGroup(ListNode head, int k) {
        if (head == null) return null;
        ListNode dummy = new ListNode(0);
        dummy.next = head;
        ListNode pre = dummy;
        while(pre != null){
            pre = Reverse(pre, k);
            }
        return dummy.next;
        }
    private ListNode Reverse(ListNode pre, int k){
        ListNode last = pre;
        for(int i = 0; i < k + 1; i++){
            last = last.next;
            if(i != k && last == null) return null;
        }
        ListNode tail = pre.next;
        ListNode curr = pre.next.next;
        while(curr != last){
            ListNode next = curr.next;
            curr.next = pre.next;
            pre.next = curr;
            tail.next = next;
            curr = next;
        }
        return tail;
    }
    
}

