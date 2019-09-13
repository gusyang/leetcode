namespace myapp
{
    /*
    101. Symmetric Tree
    Given a binary tree, check whether it is a mirror of itself (ie, symmetric around its center).
    For example, this binary tree [1,2,2,3,4,4,3] is symmetric:
        1
    / \
    2   2
    / \ / \
    3  4 4  3

    But the following [1,2,2,null,3,null,3] is not:

        1
    / \
    2   2
    \   \
    3    3
     */
    public class SymmentricTree
    {
        public bool IsSymmentric(TreeNode root){
           if(root == null){
               return true;
           } 
           return IsSymmentric(root, root);
        }
        private bool IsSymmentric(TreeNode t1, TreeNode t2){
            if(t1 == null && t2 == null){
                return true;
            }
            if(t1 == null || t2 == null){
                return false;
            }
            return t1.val == t2.val
                    && IsSymmentric(t1.left, t2.right)
                    && IsSymmentric(t1.right, t2.left);
        }
    }
}