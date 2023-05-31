/*
Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.
*/

int naturalSumValues_M_to_N(int startValue, int endValue, int SumValues)
{
    if (startValue >= endValue) return SumValues;
    SumValues += startValue;
    return naturalSumValues_M_to_N(++startValue, endValue, SumValues);
}

Console.WriteLine("Введите начальное число M: ");
int M = int.Parse(Console.ReadLine());

Console.WriteLine("Введите конечно число N: ");
int N = int.Parse(Console.ReadLine());

int sum = naturalSumValues_M_to_N(M+1, N, 0);
Console.WriteLine($"Сумма натур. элементов от {M} до {N} = {sum}");