/*
 * @lc app=leetcode id=23 lang=csharp
 *
 * [23] Merge k Sorted Lists
 * Input:
* [
*  1->4->5,
*   1->3->4,
*   2->6
* ]
Output: 1->1->2->3->4->4->5->6
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
    public ListNode MergeKLists(ListNode[] lists) {
        if(lists.Length == null || lists.Length == 0) return null;
        if(lists.Length == 1) return lists[0];
        ListNode result = Merge2List(lists[0],lists[1]);
        for(int i = 2; i < lists.Length; i++){
            result = Merge2List(result, lists[i]);
        }
        return result;
    }

    private static ListNode Merge2List(ListNode l1, ListNode l2){
        ListNode header = new ListNode(0);
        ListNode ans = header;
        while (l1 != null && l2 != null)
        {            
            if(l1.val < l2.val){
                header.next = l1;
                header = header.next;
                l1 = l1.next;
            } else
            {
                header.next = l2;
                header = header.next;
                l2 = l2.next;
            }                    
        }
        if(l1 == null) header.next = l2;
        if(l2 == null) header.next = l1;  
        return ans.next;
    }
}

