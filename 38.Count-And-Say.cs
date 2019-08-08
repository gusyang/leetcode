public class Solution
{
    public string CountAndSay(int n)
    {
        if(n == 0) return "";
        string str = "1";
        for(int i = 1; i < n; i++){
            int count = 0;
            char prev = '.';
            StringBuilder sb = new StringBuilder();
            for(int idx = 0; idx < str.Length; idx++){
                if(str[idx] == prev || prev == '.'){
                    count++;
                } else {
                    sb.Append(count + prev);
                    count = 1;
                }
                prev = str[idx];
            }
            sb.Append(count + prev);
            str = sb.ToString();
        }
        return str;

    }
}