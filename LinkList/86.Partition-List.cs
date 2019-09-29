
/*
 86. Partition List
Given a linked list and a value x, partition it such that all nodes less than x come before nodes greater than or equal to x.
You should preserve the original relative order of the nodes in each of the two partitions.

Example:
Input: head = 1->4->3->2->5->2, x = 3
Output: 1->2->2->4->3->5
     */
namespace ConsoleApp1
{

    /**
     * Definition for singly-linked list.
     */
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    public static class _86
    {
        public class Solution
        {
            public static ListNode Partition(ListNode head, int x)
            {
                if (head == null)
                {
                    return head;
                }
                //define 2 point, one for smaller than target, small head
                // another for bigger
                ListNode smallhead = new ListNode(0), bighead = new ListNode(0);
                ListNode smallend = smallhead, bigend = bighead;
                while (head != null)
                {
                    if (head.val < x)
                    {
                        //smaller than target, add node to small point
                        smallend.next = head;
                        smallend = smallend.next;
                    }
                    else
                    {
                        //bigger, add to big point
                        bigend.next = head;
                        bigend = bigend.next;
                    }
                    head = head.next;
                }
                //important, stop old link, otherwise, still like to old List link
                bigend.next = null;
                smallend.next = bighead.next;
                return smallhead.next;
            }
        }
    }
}

