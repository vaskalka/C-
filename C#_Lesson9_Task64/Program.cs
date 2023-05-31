/*
Задайте значение N. Напишите программу, которая выведет все натуральные 
числа в промежутке от N до 1. Выполнить с помощью рекурсии.
*/

void naturalValues_N_to_1 (int N)
{
    if (N <= 0) return;
    Console.WriteLine(N);
    naturalValues_N_to_1(N - 1);
}

Console.WriteLine($"Введите число N: ");
int N = int.Parse(Console.ReadLine());

Console.WriteLine("Последовательность чисел");
naturalValues_N_to_1(N);