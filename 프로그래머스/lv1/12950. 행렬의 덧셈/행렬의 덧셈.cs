using System;

public class Solution {
    public int[,] solution(int[,] arr1, int[,] arr2) {
        int[,] answer = new int[arr1.GetLength(0),arr1.GetLength(1)];
        for(int i=0; i<arr1.GetLength(0); i++){
            for(int y=0; y<arr1.GetLength(1);y++){
                answer[i,y]=arr1[i,y]+arr2[i,y];
            }
        }
        return answer;
    }
}