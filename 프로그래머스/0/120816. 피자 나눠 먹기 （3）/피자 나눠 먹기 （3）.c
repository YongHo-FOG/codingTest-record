#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

int solution(int slice, int n) {
    // 5명이 2조각으로 나눈 피자를 최소 한조각씩 먹으려면 최소 세판
    // 4명이 2조각으로 나눈 피자를 최소 한조각씩 먹으려면 최소 두판
    // 3명이 2조각으로 나눈 피자를 최소 한조각씩 먹으려면 최소 두판
    // 7명이 3조각으로 나눈 피자를 최소 한조각씩 먹으려면 최소 세판
    // n % slice 한 나머지가 0이면 최소 필요 피자는 n / slice
    // n % slice 한 나머지가 0이 아니면 필요 피자는 n / slice +1
    int answer = 0;
    if(n % slice == 0)
    {
        answer = n / slice;
    }
    else if(n % slice != 0)
    {
        answer = (n / slice) + 1;
    }
    return answer;
}