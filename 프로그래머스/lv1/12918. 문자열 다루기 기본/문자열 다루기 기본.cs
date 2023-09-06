using System;

public class Solution {
    public bool solution(string s) {
        bool answer = false;
        char[] chr = s.ToString().ToCharArray();
        int check=0;
        for(int i=0;i<chr.Length;i++){
            if(chr.Length==4 || chr.Length==6){
                if(chr[i]>='0'&&chr[i]<='9'){
                    check++;
                } else {
                    return false; 
                }
            }else{
                return false;
            }
        }
        if(check==4||check==6){
            return true;
        }
        return false;
        
    }
}