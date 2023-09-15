using System;

public class Solution {
    public int solution(int[,] sizes) {
        int answer = 0;
        int wMax = 0;
        int hMax = 0;
        bool check = false;
        
        for(int i=0; i<sizes.GetLength(0); i++){
            for(int y=0; y<2; y++){
                if(sizes[i,y]>wMax){
                    wMax=sizes[i,y];
                    if(y==1)check=true;
                }
            }
            if(sizes[i,0]>sizes[i,1]){
                if(hMax<sizes[i,1])hMax = sizes[i,1];
            }else{
                if(hMax<sizes[i,0])hMax = sizes[i,0];
            } 
        }
        answer = wMax * hMax;
        
        return answer;
    }
}