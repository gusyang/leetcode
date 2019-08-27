using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode
{
    public static class _82
    {
     /*
     Given a sorted linked list, delete all duplicates such that each element appear only once.
     Example 1:
     Input: 1->1->2
     Output: 1->2
     Example 2:
     Input: 1->1->2->3->3
     Output: 1->2->3
   */
        public static ListNode RemoveDuplicate83(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            int? prevalue = null;
            ListNode dummy = new ListNode(0);
            ListNode curr = dummy;
            while (head != null)
            {
                if(head.val == prevalue)
                {
                    head = head.next;
                    continue;
                }

                prevalue = head.val;
                curr.next = new ListNode(head.val);
                curr = curr.next;
              
                head = head.next;
            }
            return dummy.next;
        }
       /*
        Given a sorted linked list, delete all nodes that have duplicate numbers, leaving only distinct numbers from the original list.
       Example 1:
       Input: 1->2->3->3->4->4->5
       Output: 1->2->5
       Example 2:
       Input: 1->1->1->2->3
       Output: 2->3   
       */
        public static ListNode RemoveDuplicate82(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            int duplicatevalue = 0;
            bool isInit = true;
            ListNode dummy = new ListNode(0);
            ListNode curr = dummy;
            while (head != null)
            {
                if(head.next != null)
                {
                    if (head.val == head.next.val)
                    {
                        duplicatevalue = head.val;
                        isInit = false;
                    }
                }
                if ((head.val != duplicatevalue) || ( head.val == duplicatevalue && isInit) )
                {                 
                    curr.next = new ListNode(head.val);
                    curr = curr.next;
                }
                head = head.next;
            }
            return dummy.next;
        }
    }
}
