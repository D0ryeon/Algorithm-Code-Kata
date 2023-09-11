using System;

public class Solution {
    public string solution(string s) {
        string answer = "";
        
        string[] str = s.Split();
        for(int i=0; i < str.Length; i++){
            for(int z=0; z<str[i].Length;z++){
                if (z == 0)
                    {
                        answer += Char.ToUpper(str[i][z]);
                        continue;
                    }
                if (z % 2 == 0)
                    {
                        answer += Char.ToUpper(str[i][z]);
                    }
                    else
                    {
                        answer += Char.ToLower(str[i][z]);
                    }
            }
            if (i != str.Length-1)
                {
                    answer += " ";
                }
            
        }
        return answer;
    }
}