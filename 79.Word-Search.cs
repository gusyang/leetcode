/*
 Given a 2D board and a word, find if the word exists in the grid.
The word can be constructed from letters of sequentially adjacent cell, where "adjacent" cells are those horizontally or vertically neighboring. The same letter cell may not be used more than once.
Example:
board =
[
  ['A','B','C','E'],
  ['S','F','C','S'],
  ['A','D','E','E']
]

Given word = "ABCCED", return true.
Given word = "SEE", return true.
Given word = "ABCB", return false.
*/
namespace ConsoleApp1
{
    public class _79
    {
        public static bool Exist(char[][] board, string word)
        {
            if(board == null || board.Length == 0 || board[0] == null || board[0].Length == 0)
            {
                return false;
            }
            for(int i = 0; i < board.Length; i++)
            {
                for(int j = 0; j < board[0].Length; j++)
                {
                    if(ExistRe(board,i,j,word,0))
                    {
                        return true;
                    }
                }
            }
            return false;

        }
        private static bool ExistRe(char[][] board, int row, int col, string word, int idx)
        {
            if(idx == word.Length)
            {
                return true;
            }
            if(row < 0 || col < 0 || row == board.Length || col == board[0].Length)
            {
                return false;
            }
            if((board[row][col] != word[idx]))
            {
                return false;
            }
            //update current value, to void reuse
            board[row][col] = '*';
            bool isExist = (ExistRe(board, row, col + 1, word, idx + 1)
                || ExistRe(board, row, col - 1, word, idx + 1)
                || ExistRe(board, row + 1, col, word, idx + 1)
                || ExistRe(board, row - 1, col, word, idx + 1));
            //update back
            board[row][col] = word[idx];
            return isExist;
        }
    }
}
