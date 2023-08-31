using System;
public class Solution {
    public string solution(string phone_number) {
            string answer = "";

            int leng = phone_number.Length;
            string str2 = phone_number.Substring(leng - 4, 4);
            string str1 = "";
            for (int i = 0; i < leng - 4; i++)
            {
                str1 += "*";
            }
            
            answer = str1 + str2;
            return answer;
        }
}