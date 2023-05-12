//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
int[] array = GetArray(4, 100, 999);
Console.WriteLine(String.Join(" ", array));
int[] Sum = SumOdd(array);
Console.WriteLine($"{array} -> {Sum} ");
///////////////////////////////////////////////////////////
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int SumOdd(int arr);
for (int i = 0; i < arr.Length; i++) ;
{
    if (arr[i] % 2 == 1) ;
    {
        Sum += arr[i];
    }
    return Sum;
}