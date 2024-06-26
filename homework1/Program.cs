﻿// Задайте значения M и N. Напишите программу, которая выведет
//  все натуральные числа в промежутке от M до N. Использовать 
//  рекурсию, не использовать циклы.



static string PrintNumbers(int M, int N)
{
    if (M == N)
    {
        return M.ToString();
    }
    else if (M < N)
    {
        return M + ", " + PrintNumbers(M + 1, N);
    }
    else
    {
        return M + ", " + PrintNumbers(M - 1, N);
    }
}


int M = 4;
int N = 8;

string result = PrintNumbers(M, N);
Console.WriteLine(result);