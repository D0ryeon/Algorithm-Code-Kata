using System;
public class Solution {
    public int[] solution(long n) {
        char[] c = n.ToString().ToCharArray();
        int num = c.Length;
        int[] answer = new int[num];
        for(int i=0; i<c.Length;i++)
        {
            answer[num-1] = Int32.Parse(c[i].ToString());
            num--;
        }
        
        
        return answer;
    }
}