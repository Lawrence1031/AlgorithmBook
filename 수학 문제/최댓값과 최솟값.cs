using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public string solution(string s) {
        string answer = "";
        
        int maxNumber = int.MinValue;
        int minNumber = int.MaxValue;

        string[] sArray = s.Split(' ');

        List<int> sList = new List<int>();
        foreach (string sString in sArray)
        {
            int num;
            int.TryParse(sString, out num);
            sList.Add(num);
        }

        maxNumber = FindMax(sList);
        minNumber = FindMin(sList);
        answer = minNumber.ToString() + " " + maxNumber.ToString();

        return answer;
    }

    static int FindMax(List<int> List)
    {
        int max = List[0];
        for (int i = 1; i < List.Count; i++)
        {
            if (List[i] > max)
                max = List[i];
        }

        return max;
    }

    static int FindMin(List<int> List)
    {
        int min = List[0];
        for (int i = 1; i < List.Count; i++)
        {
            if (List[i] < min)
                min = List[i];
        }

        return min;
    }
}