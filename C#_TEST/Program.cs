void FillArray(int[,] collection, int strings, int colums)
{
    for (int i = 0; i < strings; i++)
    {
        for(int j = i; j < colums; j++)
        {
            collection[i, j] = (i+1) * (j+1);
            collection[j, i] = collection[i, j];
        }
    }
}

void PrintArray(int[,] collection, int strings, int colums)
{
    for (int i = 0; i < strings; i++)
    {
        for(int j = 0; j < colums; j++)
        {
            Console.Write($"{collection[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите кол-во строк массива N");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов массива M");
int M = int.Parse(Console.ReadLine());

int[,] array = new int[N, M];

FillArray(array, N, M);
PrintArray(array, N, M);