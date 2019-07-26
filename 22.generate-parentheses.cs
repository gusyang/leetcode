/*
 * @lc app=leetcode id=22 lang=csharp
 *At every position there can be a ( or ).
 *In order to place a ( the count of ( already placed should be less than n.
 *In order to place a ) the count of ) already placed should be less than count of ( alread placed.
 *In every stack frame try to first place an ( and recurse into a new stack frame. When the code comes back out try to place a ) and recurse into a new stack frame.
 *Once both ( and ) have been tried in a stack frame and you can place no more, then you have one valid possibility. Store that.
 *Before exiting the stack frame remove the last char.
 * [22] Generate Parentheses
 */
public class Solution {
  
  public IList<string> GenerateParenthesis(int n) {
       
        var list = new List<string>();
        Generate(new StringBuilder(), n, 0, 0, list);
        return list;
    }

    private void Generate(StringBuilder sb, int n, int openCount, int closeCount, IList<string> list)
    {
        if (openCount < n)
        {
            sb.Append("(");
            Generate(sb, n, openCount + 1, closeCount, list);
        }

        if (closeCount < openCount)
        {
            sb.Append(")");
            Generate(sb, n, openCount, closeCount + 1, list);
        }

        if (openCount == n && closeCount == n)
        {
            list.Add(sb.ToString());
        }

        if (sb.Length > 0)
            sb.Remove(sb.Length - 1, 1);
    }
}

