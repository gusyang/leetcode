/*
 * @lc app=leetcode id=103 lang=csharp
 *
 * [103] Binary Tree Zigzag Level Order Traversal
 *
 * https://leetcode.com/problems/binary-tree-zigzag-level-order-traversal/description/
 *
 * Testcase Example:  '[3,9,20,null,null,15,7]'
 *
 * Given a binary tree, return the zigzag level order traversal of its nodes'
 * values. (ie, from left to right, then right to left for the next level and
 * alternate between).
 * For example:
 * Given binary tree [3,9,20,null,null,15,7],
 * 
 * ⁠   3
 * ⁠  / \
 * ⁠ 9  20
 * ⁠   /  \
 * ⁠  15   7
 * 
 * 
 * 
 * return its zigzag level order traversal as:
 * 
 * [
 * ⁠ [3],
 * ⁠ [20,9],
 * ⁠ [15,7]
 * ]
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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        IList<IList<int>> res = new List<IList<int>>();
        if(root == null){
            return res;
        }
        Queue<TreeNode> treeQueue = new Queue<TreeNode>();
        bool flag = false;
        treeQueue.Enqueue(root);
        while (treeQueue.Count > 0){
            int size = treeQueue.Count;
            IList<int> lst = new List<int>();
            flag = !flag;
            for(int i = 0; i < size; i++){
                TreeNode tmpTree = treeQueue.Dequeue();
                if(flag){
                    lst.Add(tmpTree.val);
                } else{
                    lst.Insert(0, tmpTree.val);
                }
                if(tmpTree.left != null){
                    treeQueue.Enqueue(tmpTree.left);
                }
                if(tmpTree.right != null){
                    treeQueue.Enqueue(tmpTree.right);
                }
            }
            res.Add(lst);
        }
        return res;
    }
}

