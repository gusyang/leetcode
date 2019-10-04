/*
 * @lc app=leetcode id=112 lang=csharp
 *
 * [112] Path Sum
 *
 * https://leetcode.com/problems/path-sum/description/
 * Testcase Example:  '[5,4,8,11,null,13,4,7,2,null,null,null,1]\n22'
 *
 * Given a binary tree and a sum, determine if the tree has a root-to-leaf path
 * such that adding up all the values along the path equals the given sum.
 * 
 * Note: A leaf is a node with no children.
 * 
 * Example:
 * 
 * Given the below binary tree and sum = 22,
 * 
 * 
 * ⁠     5
 * ⁠    / \
 * ⁠   4   8
 * ⁠  /   / \
 * ⁠ 11  13  4
 * ⁠/  \      \
 * 7    2      1
 * 
 * 
 * return true, as there exist a root-to-leaf path 5->4->11->2 which sum is 22.
 * 
 */

// @lc code=start
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
    public bool HasPathSum(TreeNode root, int sum) {
        if(root == null){
            return false;
        }
        if(root.left == null && root.right == null ){
            if(sum == root.val){
                return true;
            }
        }
        return HasPathSum(root.left, sum - root.val) || HasPathSum(root.right, sum - root.val);
    }
}
/*
113. Path Sum II
Given a binary tree and a sum, find all root-to-leaf paths where each path's sum equals the given sum.
Note: A leaf is a node with no children.

Example:
Given the below binary tree and sum = 22,

      5
     / \
    4   8
   /   / \
  11  13  4
 /  \    / \
7    2  5   1
Return:
[
   [5,4,11,2],
   [5,8,4,5]
]
 */
public class Solution {
    public IList<IList<int>> PathSum(TreeNode root, int sum) {
        IList<IList<int>> res = new List<IList<int>> ();
        Helper(root,sum,res,new List<int>());
        return res;
    }

    private  void Helper(TreeNode root, int sum,IList<IList<int>> res, IList<int> cur){
        if(root == null){
            return;
        }
        cur.Add(root.val);
        if(root.left == null && root.right == null){
            if(sum == root.val){
                res.Add(new List<int>(cur));
            }
        }else{
            Helper(root.left,sum - root.val, res, cur);
            Helper(root.right,sum - root.val,res,cur);
        }
        cur.RemoveAt(cur.Count - 1);
    }
}
