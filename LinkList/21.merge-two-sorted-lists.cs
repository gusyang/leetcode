/*
 * @lc app=leetcode id=21 lang=csharp
 *
 * [21] Merge Two Sorted Lists
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
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        if(l1 == null) return l2;
        if(l2 == null) return l1;
        ListNode dummy = new ListNode(0);
        ListNode cur = dummy;
        while (l1 != null && l2 != null)
        {   
            if(l1.val <= l2.val){
                cur.next = l1;
                l1 = l1.next;
            } else
            {
                cur.next = l2;
                l2 = l2.next;
            }
            cur = cur.next;            
        }
        cur.next = l1 == null ? l2 : l1;
        return dummy.next;        
    }
}

