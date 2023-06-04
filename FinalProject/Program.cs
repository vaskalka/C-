void FillArray(string[] Array, int ArrayLength)
{
    Console.WriteLine("Введите элементы массива: ");
    for(int i = 0; i < ArrayLength; i++)
    {
        Array[i] = Console.ReadLine();
        Console.WriteLine($"Осталось ввести элементов: {ArrayLength -i - 1}");
    }
}


void PrintArray(string[] Array, int ArrayLength)
{
    Console.WriteLine("Ваш массив: ");
    for(int i = 0; i < ArrayLength; i++)
    {
        Console.Write($"{Array[i]} ");
    }
    Console.WriteLine();
}


void NewArrayLessOrEquallyThreeSimbols(string[] Array, int ArrayLength)
{
    string[] NewArray = new string[ArrayLength];
    int Counter = 0;
    for(int i = 0; i < ArrayLength; i++)
    {
        if(Array[i].Length <= 3)
        {
            NewArray[Counter] = Array[i];
            Counter++;
        }
    }    
    Console.WriteLine("Отсортированный массив по кол-ву символов в элементе: ");
    PrintArray(NewArray, ArrayLength);
    Console.WriteLine($"Кол-во элементов <= 3: {Counter}");
}

Console.WriteLine("Введите количество символов массива: ");
int ArrayLength = int.Parse(Console.ReadLine());
string[] Array = new string[ArrayLength];

FillArray(Array, ArrayLength);
PrintArray(Array, ArrayLength);
NewArrayLessOrEquallyThreeSimbols(Array, ArrayLength);