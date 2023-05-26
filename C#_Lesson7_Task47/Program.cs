﻿void fillArray(int[,] collection, int x, int y)
{
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            collection[i, j] = new Random().Next(1, 100);
        }
    }
}


void printArray(int[,] collection, int x, int y)
{
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            Console.Write($"{collection[i, j]} ");
        }
        Console.WriteLine();
    }    
}

Console.WriteLine("Введите число строк(X) массива: ");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число столбцов(Y) массива: ");
int y = int.Parse(Console.ReadLine());

Console.WriteLine("Ваш массив: ");
int[,] array = new int[x, y];
fillArray(array, x, y);
printArray(array, x, y);