using System;

public class Solution {
    
    enum DayName
    {
        THU,
        FRI,
        SAT,
        SUN,
        MON,
        TUE,
        WED,
    }
    
    public string solution(int a, int b) {
        string answer = "";
        int c = a - 1;
        int cnt = 0;

        for (int i = c; i > 0; i--)
        {
            if (i > 7)
            {
                if (i % 2 == 0)
                cnt++;
            }
            else
                if (i % 2 == 1)
                cnt++;
        }
        
        c = a > 2 ? c * 30 - 1 : c * 30;
        cnt = (cnt + c + b) % 7;
        
        answer = Enum.GetName(typeof(DayName), cnt);
        
        return answer;
    }
}