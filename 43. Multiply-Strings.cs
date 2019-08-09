/*
Example 1:

Input: num1 = "2", num2 = "3"
Output: "6"
Example 2:

Input: num1 = "123", num2 = "456"
Output: "56088"
Note:

The length of both num1 and num2 is < 110.
Both num1 and num2 contain only digits 0-9.
Both num1 and num2 do not contain any leading zero, except the number 0 itself.
You must not use any built-in BigInteger library or convert the inputs to integer directly.
*/
public class Solution
{
    public string Multiply(string num1, string num2)
    {
        if(num1.Length == 0 || num2.Length == 0) return "0";
        int len1 = num1.Length, len2 = num2.Length;
        int[] result = new int[len1 + len2];
        for(int i = len1 - 1; i >= 0; i--){
            for(int j = len2 - 1; j >= 0; j--){
                int mul = (num1[i] - '0') * (num2[j] - '0');
                int poslow = i + j + 1, poshigh = i + j;

                mul += result[poslow];

                result[poslow] = mul % 10;
                result[poshigh] += mul / 10;
            }
        }
        StringBuilder sb = new StringBuilder();
        foreach(int n in result){
            if(!(sb.Length == 0 && n != 0)) sb.Append(n);
        }

        return (sb.Length == 0 ? "0" : sb.ToString());
    }
}
