/*
 * https://leetcode.com/problems/restore-ip-addresses/description/
 *
 * Testcase Example:  '"25525511135"'
 *
 * Given a string containing only digits, restore it by returning all possible
 * valid IP address combinations.
 * 
 * Example:
 * Input: "25525511135"
 * Output: ["255.255.11.135", "255.255.111.35"]
 * 
 */
public class Solution {
    public IList<string> RestoreIpAddresses(string s) {
        List<string> res = new List<string>();
        if(s == null || s.Length == 0 ){
            return res;
        }
        //for a vaild IP address, it range [4,12]
        if(s.Length < 4 || s.Length > 12){
            return res;
        }
        RestoreIpHelper(res,"", s, 0);
        return res;
    }
    private static void RestoreIpHelper(IList<string> res, string curr, string s, int fields){
        if(s.Length == 0 && fields == 4){
            res.Add(curr.Substring(1));
            return;
        } else if(s.Length == 0 || fields == 4){
            return;
        }
        //use 1 number
        RestoreIpHelper(res, curr + "." + s.Substring(0,1),s.Substring(1),fields + 1);
        if(s.Length >= 2){
            int tmp = (s[0] - '0') * 10 + (s[1] - '0');
            if(tmp >= 10 && tmp < 100){
                //if 2 number is vaild, try 2 numbers
                RestoreIpHelper(res,curr + "." + s.Substring(0,2),s.Substring(2), fields + 1);
            } 
        }
        if(s.Length >= 3){
            int tmp = (s[0] - '0') * 100 + (s[1] - '0') * 10 + (s[2] - '0');
            //try 3 numbers
            if(tmp >= 100 && tmp <= 255){
                RestoreIpHelper(res,curr + "." + s.Substring(0,3),s.Substring(3),fields + 1);
            } 
        }
    }
}

