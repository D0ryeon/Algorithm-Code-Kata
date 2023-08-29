using System;
using System.Linq;

public class Solution {
    public long solution(long n) {
        long answer = 0;
        
        char[] chr = n.ToString().ToCharArray();
        string str = "";
        int[] a = Array.ConvertAll(chr,s => int.Parse(s));
        a = a.OrderByDescending(c=>c);
        for(int i=0; i<a.Length; i++){
            str += a[i].ToString();
        }
        answer = long.Parse(str);
        
        return answer;
    }
}