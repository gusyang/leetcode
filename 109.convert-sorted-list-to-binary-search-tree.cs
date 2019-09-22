/*
 * @lc app=leetcode id=109 lang=csharp
 *
 * [109] Convert Sorted List to Binary Search Tree
 *
 * https://leetcode.com/problems/convert-sorted-list-to-binary-search-tree/description/
 * Testcase Example:  '[-10,-3,0,5,9]'
 *
 * Given a singly linked list where elements are sorted in ascending order,
 * convert it to a height balanced BST.
 * 
 * For this problem, a height-balanced binary tree is defined as a binary tree
 * in which the depth of the two subtrees of every node never differ by more
 * than 1.
 * 
 * Example:
 * 
 * 
 * Given the sorted linked list: [-10,-3,0,5,9],
 * 
 * One possible answer is: [0,-3,9,-10,null,5], which represents the following
 * height balanced BST:
 * 
 * ⁠     0
 * ⁠    / \
 * ⁠  -3   9
 * ⁠  /   /
 * ⁠-10  5
 * 
 * 
 */
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public TreeNode SortedListToBST(ListNode head) {
        if(head == null){
            return null;
        }
        if(head.next == null){
            return new TreeNode(head.val);
        }
        List<ListNode> lst = new List<ListNode>();
        while (head != null){
            lst.Add(head);
            head = head.next;
        }
        return helper(lst,0,lst.Count - 1);
    }
    private TreeNode helper(List<ListNode> lst, int left, int right){
        int mid = left + (right - left) / 2;
        if(right - left == 2){
            TreeNode nd = new TreeNode(lst[mid].val);
            nd.left = new TreeNode(lst[left].val);
            nd.right = new TreeNode(lst[right].val);
            return nd;
        } else if(right - left == 1){
            TreeNode nd = new TreeNode(lst[right].val);
            nd.left = new TreeNode(lst[left].val);   
            return nd;
        } else if(right == left){
            return new TreeNode(lst[left].val);
        } else{
            TreeNode nd = new TreeNode(lst[mid].val);
            nd.left = helper(lst,left, mid - 1);
            nd.right = helper(lst,mid + 1, right);
            return nd;
        }
    }
}

