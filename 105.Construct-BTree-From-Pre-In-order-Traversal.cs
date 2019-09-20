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
        if(preorder == null || inorder == null || preorder.Length != inorder.Length){
            return null;
        }
        Dictionary<int, int> map = new Dictionary<int, int>();
        for(int i = 0; i < inorder.Length; i++){
            map.Add(inorder[i],i);
        }
        return helper(preorder, inorder, 0, 0, inorder.Length - 1, map);
    }

    private TreeNode helper(int[] preorder, int[] inorder, int prestart, int instart, int inend, Dictionary<int, int> map){
        if(instart > inend || prestart > preorder.Length - 1){
            return null;
        }
        TreeNode root = new TreeNode(preorder[prestart]);
        int idx = instart;
        idx = map[root.val];/* 
        while (idx <= inend && inorder[idx] != root.val){            
            idx++;
        }*/
        root.left = helper(preorder,inorder,prestart + 1, instart, idx - 1,map);
        root.right = helper(preorder,inorder, prestart + idx - instart + 1, idx + 1, inend,map);
        return root;
    }
}