using System;
using System.Collections.Generic;
using System.Text;
/*
 given a sorted linked list, delete all nodes that have duplicate numbers, leaving only distinnct numbers from the original list
     */
namespace leetcode
{
    public static class _82
    {
        public static ListNode RemoveDuplicate(ListNode head)
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
