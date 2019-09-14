/*
 * [102] Binary Tree Level Order Traversal
 *
 * https://leetcode.com/problems/binary-tree-level-order-traversal/description/
 * Testcase Example:  '[3,9,20,null,null,15,7]'
 *
 * Given a binary tree, return the level order traversal of its nodes' values.
 * (ie, from left to right, level by level).
 * 
 * 
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
 * return its level order traversal as:
 * 
 * [
 * ⁠ [3],
 * ⁠ [9,20],
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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        IList<IList<int>> res = new IList<IList<int>>();
        if(root == null){
            return res;
        }
        Queue<TreeNode> treeQueue = new Queue<TreeNode>();
        treeQueue.Enqueue(root);
        while (treeQueue.Count > 0){
            int size = treeQueue.Count;
            IList<int> lst = new IList<int>();
            for(int i = 0; i < size; i++){
                TreeNode tmpTreeNode = treeQueue.Dequeue();
                lst.Add(tmpTreeNode.val);
                if(tmpTreeNode.left != null){
                    treeQueue.Enqueue(tmpTreeNode.left);
                }
                if(tmpTreeNode.right != null){
                    treeQueue.Enqueue(tmpTreeNode.right);
                }
            }
            res.Add(lst);
        }
        return res;
    }
}

