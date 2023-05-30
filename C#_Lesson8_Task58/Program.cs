/*
Заполните спирально массив 4 на 4 числами от 1 до 16. (Я улучшил реализацию,
чтобы можно было задать любой массив по размерности, не только 4 на 4)
*/

void fillArray(int[,] array, int rowEnd, int colEnd)
{
    int rowStart = 0;
    int colStart = 0;
    int counter = 1;

    while (rowStart <= rowEnd && colStart <= colEnd)
    {
        // Цикл заполнения верхней линии
        for (int i = colStart; i <= colEnd; i++)
        {
            array[rowStart, i] = counter++;
        }
        rowStart++;

        // Цикл заполнения правой линии
        for (int i = rowStart; i <= rowEnd; i++)
        {
            array[i, colEnd] = counter++;
        }
        colEnd--;

        // Цикл заполнения нижней линии
        for (int i = colEnd; i >= colStart; i--)
        {
            array[rowEnd, i] = counter++;
        }
        rowEnd--;

        // Цикл заполнения левой линии
        for (int i = rowEnd; i>= rowStart; i--)
        {
            array[i, colStart] = counter++;
        }
        colStart++; 
    }
}


void printArray(int[,] array, int n, int k)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < k; j++) 
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}


Console.WriteLine($"Введите количество строк массив (rowEnd): ");
int rowEnd = int.Parse(Console.ReadLine());

Console.WriteLine($"Введите количество столбцов массив (colEnd): ");
int colEnd = int.Parse(Console.ReadLine());

int[,] array = new int[rowEnd, colEnd];

fillArray(array, rowEnd-1, colEnd-1);
printArray(array, rowEnd, colEnd);
