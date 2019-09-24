/*
 * @lc app=leetcode id=111 lang=csharp
 *
 * [111] Minimum Depth of Binary Tree
 *
 * https://leetcode.com/problems/minimum-depth-of-binary-tree/description/
 *
 * Testcase Example:  '[3,9,20,null,null,15,7]'
 *
 * Given a binary tree, find its minimum depth.
 * 
 * The minimum depth is the number of nodes along the shortest path from the
 * root node down to the nearest leaf node.
 * 
 * Note: A leaf is a node with no children.
 * 
 * Example:
 * 
 * Given binary tree [3,9,20,null,null,15,7],
 * 
 * 
 * ⁠   3
 * ⁠  / \
 * ⁠ 9  20
 * ⁠   /  \
 * ⁠  15   7
 * 
 * return its minimum depth = 2.
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
    public int MinDepth(TreeNode root) {
        if(root == null){
            return 0;
        }
        int left = MinDepth(root.left);
        int right = MinDepth(root.right);
        return (left == 0 || right == 0) ? left + right + 1 : Math.Min(left,right) + 1;
    }

    public int MinDepth1(TreeNode root) {
        if(root == null){
            return 0;
        }
        Queue<TreeNode> tq = new Queue<TreeNode>();
        int level = 1;
        tq.Enqueue(root);
        while (tq.Count > 0){
            int size = tq.Count;
            for(int i = 0; i < size; i++){
                TreeNode tn = tq.Dequeue();
                if(tn.left == null && tn.right == null){
                    return level;
                }
                if(tn.left != null){
                    tq.Enqueue(tn.left);
                }
                if(tn.right != null){
                    tq.Enqueue(tn.right);
                }
            }
            level++;
        }
        return level;
    }
}

