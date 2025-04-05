using System;

public class Solution {
    public int solution(int[] sides) {
        int answer = 0;
        Array.Sort(sides);
        int A = sides.Length;
        int max = sides[A - 1];
        if (max < sides[0] + sides[1])
        {
            answer = 1;
        }
        else if ( max >= sides[0] + sides[1])
        {
            answer = 2;
        }
        return answer;
    }
}