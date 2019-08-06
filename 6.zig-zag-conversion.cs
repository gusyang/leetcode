/*
 * @lc app=leetcode id=6 lang=csharp
 *
 * [6] ZigZag Conversion
 */
public class Solution {
    public string Convert(string s, int numRows) {
        //defensive protect
        if(s == null || s == "" || numRows == 1 || s.Length <= numRows) return s;

        List<StringBuilder>  list = new List<StringBuilder>();
       //init list
        for(int i = 0; i < numRows; i++){
            list.Add(new StringBuilder());
        }
        
        int currentRow = 0;
        bool goDown = false;

        foreach (char c in s)
        {
            list[currentRow].Append(c);
            if(currentRow == 0 || currentRow == numRows - 1){
                goDown = !goDown;
            }
            currentRow += goDown ? 1 : -1;             
        }
        StringBuilder result = new StringBuilder();
        foreach(StringBuilder sb in list) 
            result.Append(sb);
            
        return result.ToString();
    }
}

