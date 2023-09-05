using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        long sum=0;
        for(int i=0;i<count;i++){
            sum+=price*(i+1);
        }
        long answer=sum-money;
        if(answer<=0){
            return 0;
        }
        return answer;
    }
}