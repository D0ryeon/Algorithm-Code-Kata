using System;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        int[] answer = new int[commands.GetLength(0)];
        
        for(int i=0; i<commands.GetLength(0);i++){
            answer[i]= number(array,commands[i,0],commands[i,1],commands[i,2]);
        }
        
        
        return answer;
    }
    
    
    public int number(int[] array, int startIndex, int lastIndex, int sortIndex){
        int length = lastIndex+1-startIndex;
        int[] sort = new int[length];
        Array.Copy(array, startIndex-1, sort, 0, length);
        Array.Sort(sort);
        
        return  sort[sortIndex-1];
        
    }
}