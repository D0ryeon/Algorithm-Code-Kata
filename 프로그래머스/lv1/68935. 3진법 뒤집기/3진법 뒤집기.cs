using System;
using System.Text;
using System.Collections.Generic;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        int f = n;
        List<int> list = new List<int>();
        
        while(f!=0){
            int d=f%3;
            list.Add(d);
            f/= 3;
        }
        list.Reverse();
        
        
        for(int i = 0; i<list.Count; i++)
        {
            answer += (int)(list[i] * Math.Pow(3,i));
        }
        
        return answer;
    }
}