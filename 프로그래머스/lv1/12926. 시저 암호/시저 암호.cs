using System;
using System.Text;

public class Solution {
    public string solution(string s, int n) {
       string answer = "";
            char[] chr = s.ToCharArray();
            StringBuilder str = new StringBuilder();


            //char myChar = (char)a;

            for (int i = 0; i < chr.Length; i++)
            {
                if (chr[i] == ' ')
                {
                    str.Append(chr[i].ToString());
                    continue;
                }


                int a = (int)chr[i] + n;
                if (chr[i] >= 'A' && chr[i] <= 'Z')
                {
                    if(a>'Z'){
                        a-=26;
                    }
                }
                else
                {
                    if(a>'z'){
                        a-=26;  
                    }
                }
                str.Append(((char)a).ToString());

            }

            answer = str.ToString();
              return answer;
    }
}