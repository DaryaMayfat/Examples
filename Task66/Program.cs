// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int m = InputInt("Введите натуральное число M: ");
int n = InputInt("Введите натуральное число N: ");
Console.WriteLine($"Сумма элементов от {m} до {n} = {Sum(m, n)}");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int Sum(int m, int n)
{
    if (m == n)
        return n;
    return n + Sum(m, n - 1);
}
