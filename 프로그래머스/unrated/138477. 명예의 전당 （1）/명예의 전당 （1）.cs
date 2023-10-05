using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int k, int[] score) {
        List<int> answer = new List<int>();
        
        int day = score.Length;
        
        for(int x=1; x<=day; x++){
            // TodayArray로 배열을 받아와서 돌림 
            int[] temp = TodayArray(k,score,x);
            // 메소드에서 받아온 값의 제일 낮은 점수를 Answer에 Add하기
            answer.Add(temp[temp.Length-1]);
            // 반복
        }
        int[] answerAr = answer.ToArray();
        
        return answerAr;
    }

    public int[] TodayArray(int count, int[] score, int day){
        // 배열 선언
        int[] todayArray = new int[day];
        int[] resultArray= new int[count];
        // scroe[day-1]로 잘라서 배열을 만듬
        todayArray = score.Take(day).ToArray();
        // 내림차순 , Reverse
        Array.Sort(todayArray);
        Array.Reverse(todayArray);
        // index 0번부터 count번까지 자름
        if(day>=count){
            resultArray = todayArray.Take(count).ToArray();
        }else{
            resultArray = todayArray;
        }
        return resultArray;
    }
    
}

