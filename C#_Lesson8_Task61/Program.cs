/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Перемножение по правилу стобцы==строкам
*/

void fillArray(int[,] Matrix, int rowsAmount, int columsAmount)
{
    for (int i = 0; i < rowsAmount; i++)
    {
        for (int j = 0; j < columsAmount; j++)
        Matrix[i, j] = new Random().Next(1, 10);
    }
}


void printArray(int[,] Matrix, int rowsAmount, int columsAmount)
{
    for (int i = 0; i < rowsAmount; i++)
    {
        for (int j = 0; j < columsAmount; j++)
        Console.Write($"{Matrix[i, j]} ");
        Console.WriteLine();
    }
}


void quadraticMatrixComposition(int[,] Matrix1, int[,] Matrix2, 
int rowsAmount1m, int columsAmount1m, 
int rowsAmount2m, int columsAmount2m)
{  
    if (columsAmount1m == rowsAmount2m || rowsAmount1m == columsAmount2m)
    {
        int[,] resultMatrix = new int[rowsAmount1m, columsAmount2m];
        
        for (int i = 0; i < rowsAmount1m; i++)
        {
            for (int j = 0; j < columsAmount2m; j++)
            {
                int sum = 0;
                for (int k = 0; k < columsAmount1m; k++)
                {
                    sum += Matrix1[i, k] * Matrix2[k, j];
                }
                resultMatrix[i, j] = sum;
            }
        }
        
        Console.WriteLine("Результат перемножения матриц:");
        printArray(resultMatrix, rowsAmount1m, columsAmount2m);
    }
    else
    {
        Console.WriteLine("Не удалось выполнить перемножение матриц: неправильные размерности.");
    }
}


Console.WriteLine($"Введите количество строк первой матрицы: ");
int rowsAmount1m = int.Parse(Console.ReadLine());
Console.WriteLine($"Введите количество столбцов первой матрицы: ");
int columsAmount1m = int.Parse(Console.ReadLine());

Console.WriteLine($"Введите количество строк второй матрицы: ");
int rowsAmount2m = int.Parse(Console.ReadLine());
Console.WriteLine($"Введите количество столбцов второй матрицы: ");
int columsAmount2m = int.Parse(Console.ReadLine());

int[,] Matrix1 = new int[rowsAmount1m, columsAmount1m];
int[,] Matrix2 = new int[rowsAmount2m, columsAmount2m];

Console.WriteLine("Первая матрица: ");
fillArray(Matrix1, rowsAmount1m, columsAmount1m);
printArray(Matrix1, rowsAmount1m, columsAmount1m);

Console.WriteLine("Вторая матрица: ");
fillArray(Matrix2, rowsAmount2m, columsAmount2m);
printArray(Matrix2, rowsAmount2m, columsAmount2m);

quadraticMatrixComposition(
Matrix1, Matrix2, 
rowsAmount1m, columsAmount1m,
rowsAmount2m, columsAmount2m);
