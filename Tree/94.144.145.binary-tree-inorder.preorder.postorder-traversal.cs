/*
 * @lc app=leetcode id=94 lang=csharp
 *
 * [94] Binary Tree Inorder Traversal
 *
 * https://leetcode.com/problems/binary-tree-inorder-traversal/description/
 * Testcase Example:  '[1,null,2,3]'
 *
 * Given a binary tree, return the inorder traversal of its nodes' values.
 * 
 * Example:
 * 
 * 
 * Input: [1,null,2,3]
 * ⁠  1
 * ⁠   \
 * ⁠    2
 * ⁠   /
 * ⁠  3
 * 
 * Output: [1,3,2]
 * 
 * Follow up: Recursive solution is trivial, could you do it iteratively?
 * 
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public IList<int> InorderTraversal(TreeNode root) {
        List<int> res = new List<int> ();
        DFSInorder( root,res);
        return res;
    }

    private void DFSInorder(TreeNode root, List<int> res){
        //terminate judge
        if(root == null) {
            return;
        }
        //inorder: left, root, right
        DFSInorder(root.left,res);
        res.Add(root.val);
        DFSInorder(root.right,res);
    }


/*144. Binary Tree Preorder Traversal
Given a binary tree, return the preorder traversal of its nodes' values.

Example:
Input: [1,null,2,3]
   1
    \
     2
    /
   3
Output: [1,2,3] 
*/

     private void DFSPreorder(TreeNode root, List<int> res){
        //terminate judge
        if(root == null) {
            return;
        }
        //prorder: root,left, right
        res.Add(root.val);
        DFSPreorder(root.left,res);
        DFSPreorder(root.right,res);
    }
}

/*145. Binary Tree Postorder Traversal
Given a binary tree, return the postorder traversal of its nodes' values.

Input: [1,null,2,3]
   1
    \
     2
    /
   3

Output: [3,2,1] */
 private void DFSPostorder(TreeNode root, List<int> res){
        //terminate judge
        if(root == null) {
            return;
        }
        //postorder:  left,rigt,root
        DFSPostorder(root.left,res);
        DFSPostorder(root.right,res);
        res.Add(root.val);
    }
//Iterating method using Stack
      public IList<int> PostorderTraversal(TreeNode root) {
        List<int> res = new List<int> ();
        Stack<TreeNode> stack = new Stack<TreeNode>();
        if (root == null)
        return res;

        stack.Push(root);
        TreeNode head = root;
        while (stack.Count > 0) {
            TreeNode top_Stack = stack.Peek();
            if ((top_Stack.left == null && top_Stack.right == null) || top_Stack.right == head || top_Stack.left == head) {
                res.Add(top_Stack.val);
                stack.Pop();
                head = top_Stack;
            } else {
                if (top_Stack.right != null){
                    stack.Push(top_Stack.right);
                    }
                if (top_Stack.left != null){
                    stack.Push(top_Stack.left);
                    }
            }
        }
        return res;
    }
