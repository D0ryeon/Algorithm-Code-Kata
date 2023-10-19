using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] answers) {
        List<int> answer = new List<int>();
        int[] cord1 = new int[5]{1,2,3,4,5};
        int[] cord2 = new int[8]{2,1,2,3,2,4,2,5};
        int[] cord3 = new int[10]{3,3,1,1,2,2,4,4,5,5};
        int[] count = new int[3]{0,0,0};
        
        for(int i=0; i<answers.Length;i++){
            if(cord1[i%5]==answers[i]){
                count[0]++;
            }
            if(cord2[i%8]==answers[i]){
                count[1]++;
            }
            if(cord3[i%10]==answers[i]){
                count[2]++;
            }
        }
        
        int max= count.Max();
        for(int i=0; i<count.Length; i++){
            if(count[i]==max){
                answer.Add(i+1);
            }
        }
        
        return answer.ToArray();
    }
}