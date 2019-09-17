/*
105. Construct Binary Tree from Preorder and Inorder Traversal
Given preorder and inorder traversal of a tree, construct the binary tree.
Note:
You may assume that duplicates do not exist in the tree.
For example, given

preorder = [3,9,20,15,7]
inorder = [9,3,15,20,7]

Return the following binary tree:

 3
/ \
9 20
  / \
  15 7
  */
/**
* Definition for a binary tree node.
* struct TreeNode {
* int val;
* TreeNode *left;
* TreeNode *right;
* TreeNode(int x) : val(x), left(NULL), right(NULL) {}
* };
*/

public class Solution {
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        return helper(preorder, inorder, 0, 0, inorder.Length - 1);
    }

    private TreeNode helper(int[] preorder, int[] inorder, int prestart, int instart, int inend){
        if(instart > inend || prestart > preorder.Length - 1){
            return null;
        }
        TreeNode root = new TreeNode(preorder[prestart]);
        int idx = instart;
        while (idx <= inend && inorder[idx] != root.val){            
            idx++;
        }
        root.left = helper(preorder,inorder,prestart + 1, instart, idx - 1);
        root.right = helper(preorder,inorder, prestart + idx - instart + 1, idx + 1, inend);
        return root;
    }
}