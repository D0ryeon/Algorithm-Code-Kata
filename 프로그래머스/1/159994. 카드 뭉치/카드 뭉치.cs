using System;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
        int cards1Num=0;
        int cards2Num=0;
        
        for(int i = 0; i < goal.Length; i++){
            if(cards1Num<cards1.Length&&goal[i]==cards1[cards1Num]){
                cards1Num++;
                continue;
            }else if(cards2Num<cards2.Length&&goal[i]==cards2[cards2Num]){
                cards2Num++;
                continue;
            }else{
                return "No";
            }
        }
        
        return "Yes";

    }

}