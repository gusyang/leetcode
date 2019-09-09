
/*
 95. Unique Binary Search Trees II

Given an integer n, generate all structurally unique BST's (binary search trees) that store values 1 ... n.

Example:
Input: 3
Output:
[
  [1,null,3,2],
  [3,2,null,1],
  [3,1,null,null,2],
  [2,1,3],
  [1,null,2,null,3]
]
Explanation:
The above output corresponds to the 5 unique BST's shown below:

   1         3     3      2      1
    \       /     /      / \      \
     3     2     1      1   3      2
    /     /       \                 \
   2     1         2                 3
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

 using System;
using System.Collections;
namespace vsdebug
{
    public class BinarySearchTreeII {
        public IList<TreeNode> GenerateTrees(int n) {if(n == 0){
                return new List<TreeNode>();
            }
            return GenerateTrees(1,n);
        }

        private IList<TreeNode> GenerateTrees(int start, int end)
        {
            IList<TreeNode> res = new List<TreeNode>();
            if(start > end){ 
                res.Add(null);             
                return res;
            }
            if(start == end){
                res.Add(new TreeNode(start));
                return res;
            }
            IList<TreeNode> left, right;
            for(int i = start; i <= end; i++){
                left = GenerateTrees(start, i - 1);
                right = GenerateTrees(i + 1, end);
                foreach(TreeNode ltn in left){
                    foreach(TreeNode rtn in right){
                        TreeNode r = new TreeNode(i);
                        r.left = ltn;
                        r.right = rtn;
                        res.Add(r);
                    }
                }
            }
        return res;
        }
    }
}