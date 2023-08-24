using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        char[] chr = n.ToString().ToCharArray();
        
        foreach(char c in chr)
        {
            answer += Int32.Parse(c.ToString());  
        }
        
        return answer;
    }
}