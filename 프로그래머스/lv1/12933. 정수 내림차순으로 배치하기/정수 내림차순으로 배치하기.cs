using System;
using System.Linq;

public class Solution {
    public long solution(long n) {
        long answer = 0;
        
        char[] chr = n.ToString().ToCharArray();
        Array.Sort(chr);
        Array.Reverse(chr);
        answer = Convert.ToInt64(new string(chr));
        
        return answer;
    }
}