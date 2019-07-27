/*
 * @lc app=leetcode id=20 lang=csharp
 *
 * [20] Valid Parentheses
 */
public class Solution {
    public bool IsValid(string s) {
        if(s == null ) return false;
        Dictionary<char,char> pair = new Dictionary<char,char>{
            {')','('},
            {']','['},
            {'}','{'}
        };

         Stack<char> stk = new Stack<char>();
        foreach(char c in s){
          // if its opening bracket simply push it in stack
            if(c == '(' || c == '{' || c == '[')
            {
                stk.Push(c);
            }
            // if its closing bracket stack must have count > 0
            else if(stk.Count > 0)
            {
                // for this closing bracket we should have corresponding opening bracket
                char chk = pair.ContainsKey(c) ? pair[c] : ' ';
                if(stk.Peek() == chk)
                    stk.Pop();
                else
                    return false;
            }
            // return false if we get closing brackt & we have nothing in stack.
            // because first bracket cannot be closing bracket
            else
            {
                return false;
            }
        }
        
        return stk.Count == 0;
    }
}
