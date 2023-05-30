/* 
Задайте двумерный массив. Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.
*/

void fillArray(int[,] collection, int x, int y)
{
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            collection[i, j] = new Random().Next(1, 100);
        }
    }
}


void sortArray(int[,] collection, int x, int y)
{
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y - 1; j++)
        {
            // Проходим по элементам строки и сравниваем текущий элемент с предыдущим
            for (int k = 0; k < y - j - 1; k++)
            {
                if (collection[i, k] < collection[i, k + 1])
                {
                    // Если текущий элемент меньше следующего, меняем их местами
                    int temp = collection[i, k];
                    collection[i, k] = collection[i, k + 1];
                    collection[i, k + 1] = temp;
                }
            }
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

int[,] array = new int[x, y];
fillArray(array, x, y);
Console.WriteLine("Ваш текущий массив: ");
printArray(array, x, y);

Console.WriteLine("Ваш отсортированный массив: ");
sortArray(array, x, y);
printArray(array, x, y);
