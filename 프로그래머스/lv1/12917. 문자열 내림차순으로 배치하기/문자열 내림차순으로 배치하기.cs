using System;

public class Solution {
    public string solution(string s) {
        string answer = "";
        char[] chr = s.ToString().ToCharArray();
        Array.Sort(chr);
        Array.Reverse(chr);
        answer=string.Join("", chr);
        return answer;
    }
}