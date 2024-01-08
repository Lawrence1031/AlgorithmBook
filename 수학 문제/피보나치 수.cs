public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        int curNum = 1;
        int preNum = 0;

        for (int i = 2; i <= n; i++)
        {
            answer = (preNum + curNum) % 1234567;
            preNum = curNum % 1234567;
            curNum = answer % 1234567;
        }
        
        return answer;
    }
}