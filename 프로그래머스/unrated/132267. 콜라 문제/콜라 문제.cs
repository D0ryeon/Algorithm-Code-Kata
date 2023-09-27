using System;

public class Solution {
    public int solution(int a, int b, int n) {
        int answer = 0;
        while (n>=a){
            
            int bottle = (n/a)*b;
            int temp = n%a;
            n = bottle+temp;
            answer+=bottle;
        }
    
        return answer;
    }
}