using System;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[s.Length];
        int count;
        for(int i=0; i<s.Length; i++){
            count = -1;
            for(int y=i-1; y>=0; y--){
                if(s[i] == s[y]){
                    count = i-y;
                    break;     
                }
            }
            answer[i]  = count;
            
        }
        return answer;
    }
}