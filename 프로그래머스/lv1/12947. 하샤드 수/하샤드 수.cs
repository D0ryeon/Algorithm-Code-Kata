using System;

public class Solution {
    public bool solution(int x) {
        bool answer = false;
        int sum=0;
        char[] chr= x.ToString().ToCharArray();
        for(int i =0; i<chr.Length; i++){
            sum += Int32.Parse(chr[i].ToString());
        }
        if(x%sum==0){
            answer= true;
        }
        return answer;
    }
}