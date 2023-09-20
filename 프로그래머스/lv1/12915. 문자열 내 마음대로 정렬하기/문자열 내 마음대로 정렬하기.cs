using System;


public class Solution {
    public string[] solution(string[] strings, int n) {
        int leng = strings.Length;
        string[] answer = new string[leng];
        for(int i=0; i<strings.Length; i++)
        {
            string str = strings[i].Substring(n,1);
            strings[i] = str + strings[i]; 
        }
        Array.Sort(strings);

        for(int i = 0; i < strings.Length; i++)
        {
            answer[i] = strings[i].Substring(1);
        }

        return answer;
    }
}