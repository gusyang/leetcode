/*
 * @lc app=leetcode id=106 lang=csharp
 *
 * [106] Construct Binary Tree from Inorder and Postorder Traversal
 *
 * https://leetcode.com/problems/construct-binary-tree-from-inorder-and-postorder-traversal/description/
 *
 * Testcase Example:  '[9,3,15,20,7]\n[9,15,7,20,3]'
 *
 * Given inorder and postorder traversal of a tree, construct the binary tree.
 * 
 * Note:
 * You may assume that duplicates do not exist in the tree.
 * 
 * For example, given
 * 
 * 
 * inorder = [9,3,15,20,7]
 * postorder = [9,15,7,20,3]
 * 
 * Return the following binary tree:
 * 
 * 
 * ⁠   3
 * ⁠  / \
 * ⁠ 9  20
 * ⁠   /  \
 * ⁠  15   7
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
    //int rootIndex = 0;
    public TreeNode BuildTree(int[] inorder, int[] postorder) {
        if(postorder == null || inorder == null || postorder.Length != inorder.Length){
            return null;
        }
        Dictionary<int, int> map = new Dictionary<int, int>();
        for(int i = 0; i < inorder.Length; i++){
            map.Add(inorder[i],i);
        }
        int rootIndex = postorder.Length - 1;
        return helper(inorder,postorder,0,inorder.Length - 1,map, ref rootIndex);
    }
    private TreeNode helper(int[] inorder, int[] postorder,int inStart, int inEnd, Dictionary<int, int> map, ref int rootIndex ){
        if(inStart > inEnd || rootIndex < 0 || inStart < 0) {
            return null;
        }
        TreeNode root = new TreeNode(postorder[rootIndex]); 
        rootIndex--;
        int idx = map[root.val];
        //right first
        root.right = helper(inorder,postorder,idx + 1, inEnd,map, ref rootIndex);
        root.left = helper(inorder,postorder,inStart,idx - 1,map, ref rootIndex);
        return root;
    }
}

