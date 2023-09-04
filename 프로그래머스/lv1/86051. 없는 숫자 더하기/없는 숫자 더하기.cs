using System;
using System.Linq;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        int[] first = {1,2,3,4,5,6,7,8,9};
        var exc = first.Except(numbers);
        
        foreach(int num in exc){
            answer+=num;
        }
        
        return answer;
    }
}