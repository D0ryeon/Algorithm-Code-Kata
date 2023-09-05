using System;

public class Solution {
    public int solution(int left, int right) {
        int answer =0;
        for(int i=left; i<=right;i++){
            int count=0;
            for(int z=1; z<=i; z++){
                if(i%z==0){
                    count++;
                }
            }
            if(count%2==0){
                answer+=i;
            }else{
                answer-=i;
            }
        }
        return answer;
    }
}