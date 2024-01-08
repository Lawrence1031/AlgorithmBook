public class Solution {
    public int solution(int[] arr) {
        int answer = 0;
        
        answer = LCMArray(arr);
        return answer;
    }
    
    static int GCD(int a, int b)
    {
        return (a % b == 0 ? b : GCD(b, a % b));
    }

    static int LCM(int a, int b)
    {
        return (a * b) / GCD(a, b);
    }
    
    static int LCMArray(int[] numbers)
    {
        int result = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
        {
            result = LCM(result, numbers[i]);
        }
        return result;
    }
}