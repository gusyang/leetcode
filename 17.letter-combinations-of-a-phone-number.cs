/*
 * @lc app=leetcode id=17 lang=csharp
 *
 * [17] Letter Combinations of a Phone Number
 */
public class Solution {
    private static string[] phonemap = new string[]{        
        "","","abc","def","ghi","jkl","mno","pqrs","tuv","wxyz"
    };
    public IList<string> LetterCombinations(string digits) {
        //return Iterative(digits);
        return Recursion(digits);

    }
      
    private static IList<string> Iterative (string digits){
        List<string> result = new List<string>();
        if(digits == null || digits == "") return result;
        string[] map = new string[]{
        "","","abc","def","ghi","jkl","mno","pqrs","tuv","wxyz"
        };

        foreach(char d in digits){
            List<string> tmp = new List<string>();
            foreach(char c in map[d - '0']){
                foreach(string a in result){
                    tmp.Add(a + c);
                }
            }
            result = tmp;
        }
        return result;
    }

    private static IList<string> Recursion(string digits){
        List<string> result = new List<string>();
        if(digits == null || digits == "") return result;
        combines("", digits, 0, result);
        return result;
    }

    private static void combines(string prefix, string digits, int cur, List<string> ret){
        if(cur == digits.Length){
            ret.Add(prefix);
            return;
        }
        string letters = phonemap[digits[cur] - '0'];
        for(int i = 0; i < letters.Length; i++){
            combines(prefix + letters[i], digits, cur + 1, ret);
        }
    }
}

