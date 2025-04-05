using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        // 최대값은 정수 배열 내의 숫자가 가장 큰것과 두번째로 큰것을 곱해야함
        // 오름차순으로 정렬하여 가장 큰 수가 맨 뒤로 가게 설정
        Array.Sort(numbers);

        // 정렬하면 가장 큰 수와 두번째로 큰 수가 배열 자리의 마지막 , 마지막-1자리임
        int n = numbers.Length;
        answer = numbers[n - 1] * numbers[n - 2];

        return answer;
    }
}