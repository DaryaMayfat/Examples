﻿// Найти максимум из 9 чисел
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int a1 = 15;
int a2 = 21;
int a3 = 39;
int b1 = 12;
int b2 = 2311;
int b3 = 1;
int c1 = 80;
int c2 = 23;
int c3 = 313;

int max1 = Max (a1, b1, c1);
int max2 = Max (a2, b2, c2);
int max3 = Max (a3, b3, c3);

int max = Max(max1, max2, max3);
Console.WriteLine(max);

