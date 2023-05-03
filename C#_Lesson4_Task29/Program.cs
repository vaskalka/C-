/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
*/

void FillArray(int[] curArray)
{
    Console.WriteLine("Введите элементы массива через Enter: ");
    for (int i = 0; i < curArray.Length; i++)
    {
        int curValue = int.Parse(Console.ReadLine());
        curArray[i] = curValue;
    }
}

void PrintArray(int[] curArray)
{
    Console.Write("Ваш массив: ");
    for (int i = 0; i < curArray.Length; i++)
    {
        Console.Write($"{curArray[i]}, ");
    }
}

Console.WriteLine("Введите размер массива: ");
int length = int.Parse(Console.ReadLine());
int[] myArray = new int[length];

FillArray(myArray);
PrintArray(myArray);
