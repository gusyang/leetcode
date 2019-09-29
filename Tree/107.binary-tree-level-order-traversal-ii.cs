/*
 * @lc app=leetcode id=107 lang=csharp
 * [107] Binary Tree Level Order Traversal II
 *
 * https://leetcode.com/problems/binary-tree-level-order-traversal-ii/description/
 *
 * Testcase Example:  '[3,9,20,null,null,15,7]'
 *
 * Given a binary tree, return the bottom-up level order traversal of its
 * nodes' values. (ie, from left to right, level by level from leaf to root).
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
 * return its bottom-up level order traversal as:
 * 
 * [
 * ⁠ [15,7],
 * ⁠ [9,20],
 * ⁠ [3]
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
    public IList<IList<int>> LevelOrderBottom(TreeNode root) {
        IList<IList<int>> res = new List<IList<int>>();
        if(root == null){
            return res;
        }
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while (queue.Count > 0){
            int count = queue.Count;
            IList<int> lst = new List<int>();
            for(int i = 0; i < count; i++){
                TreeNode tn = queue.Dequeue();
                lst.Add(tn.val);
                if(tn.left != null){
                    queue.Enqueue(tn.left);
                }
                if(tn.right != null){
                    queue.Enqueue(tn.right);
                }
            }
            //res.Add(lst); //
            res.Insert(0,lst); //use insert to add new list to first, so that reversed.
        }
        /* if use add, need reverse result again 
        IList<IList<int>> res1 = new List<IList<int>>();
        for(int i = res.Count - 1; i >=0; i--){
            res1.Add(res[i]);
        }
        return res1;
        */
    }
}

