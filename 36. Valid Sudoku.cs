public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        HashSet<string> seen = new HashSet<string>();
        for (int i = 0; i < 9; ++i)
        {
            for (int j = 0; j < 9; ++j)
            {
                char number = board[i][j];
                if (number != '.')
                    if (!seen.Add(number + " in row " + i) ||
                        !seen.Add(number + " in column " + j) ||
                        !seen.Add(number + " in block " + i / 3 + "-" + j / 3))
                        return false;
            }
        }
        return true;
    }
}