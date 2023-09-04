using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        if(arr.Length==1)return new int[] {-1};
        int[] answer = new int[] {};
        int min = arr.Min();
        List<int> list = new List<int>();
        list.AddRange(arr);
        list.Remove(min);
        
        answer = list.ToArray();
        
        
        
        return answer;
    }
}