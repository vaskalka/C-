/*
Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
*/

void fillArray(int[,] array, int x, int y)
{
    for (int i = 0; i < y; i++)
    {
        for (int j = 0; j < x; j++)
        {
            array[i, j] = new Random().Next(-100, 100);
        }
    }
}


void printArray(int[,] array, int x, int y)
{
    for (int i = 0; i < y; i++)
    {
        for (int j = 0; j < x; j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}


void minSumOfValuesInString(int[,] array, int x, int y)
{
    int[] arrayOfSumValuesInString = new int[y];

    for (int i = 0; i < y; i++)
    {
        int sumValuesInString = 0;
        for (int j = 0; j < x; j++)
        {
            sumValuesInString += array[i, j]; 
        }
        Console.WriteLine($"Сумма элементов в строке {i+1} = {sumValuesInString}");
        arrayOfSumValuesInString[i] = sumValuesInString;
    }

    int minOfValuesInString = arrayOfSumValuesInString[0];

    for (int i = 0; i < y; i++)
    {
        if (arrayOfSumValuesInString[i] < minOfValuesInString)
        {
            minOfValuesInString = arrayOfSumValuesInString[i];
        }
    }

    int indexOfMinString = 1 + Array.IndexOf(arrayOfSumValuesInString, minOfValuesInString);
    Console.WriteLine($"Минимальная сумма элементов в строке "+
    $"{indexOfMinString} и равна {minOfValuesInString}");
}


Console.WriteLine($"Введите количество строк массива X: ");
int x = int.Parse(Console.ReadLine());

Console.WriteLine($"Введите количество столбцов массива Y: ");
int y = int.Parse(Console.ReadLine());

Console.WriteLine("Массив: ");
int[,] array = new int[x, y];

fillArray(array, y, x);
printArray(array, y, x);
minSumOfValuesInString(array, y, x);