using System;

public class Solution {
    public string solution(string s) {
        string answer = "";
        int leng = s.Length;
        if(leng%2==0){
            answer= s.Substring(leng/2-1,2);
        }
        else
        {
            answer= s.Substring(leng/2,1);
        }
        
        return answer;
    }
}