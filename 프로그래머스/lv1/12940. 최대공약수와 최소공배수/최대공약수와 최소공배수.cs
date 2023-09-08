public class Solution {
    public int[] solution(int n, int m) {
        int[] answer = { };
        int temp, remain, firstNum = n, SecondNum = m;
        if (n < m)
        {
            temp = firstNum;
            firstNum = SecondNum;
            SecondNum = temp;
        }
        while (SecondNum != 0)
        {
            remain = firstNum % SecondNum;
            firstNum = SecondNum;
            SecondNum = remain;

        }
        int GCD = firstNum;
        // 최소 공배수
        int LCM = n * m / GCD;

        answer = new int[] { GCD, LCM };
        return answer;
    }
}