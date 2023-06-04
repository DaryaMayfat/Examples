// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
int n = GetUserNumber("Введите положительное число ");
int m = 1;
if (n < 1)
{
    Console.WriteLine("Вы ввели не положительное число");
}
Console.WriteLine(NaturalNumber(n, m));

int GetUserNumber(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}


int NaturalNumber(int n, int m)
{
    if (n == m)
        return n;
    else
        Console.Write($"{NaturalNumber(n, m + 1)}, ");
    return m;
}

