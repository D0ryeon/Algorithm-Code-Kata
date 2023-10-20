using System;

public class Solution {
    public int solution(int n, int m, int[] section) {
        int answer = 0;
        int num = 0;
        
        // section의 Length만큼 반복
        for(int i = 0; i < section.Length; i++)
        {
            // 저장한 값보다 크면 페인트질
            if(section[i] > num)
            {
                //배열의 첫 값부터 첫 페인트질 시작하고 그 값을 저장해둠
                num = (section[i] + m) - 1;
                //페인트질 ++
                answer++;
            }
        }
        
        return answer;
    }
}