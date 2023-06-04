void FillArray(string[] Array, int ArrayLength)
{
    Console.WriteLine("Введите элементы массива: ");
    for(int i = 0; i < ArrayLength; i++)
    {
        Array[i] = Console.ReadLine();
        Console.WriteLine($"Осталось ввести элементов: {ArrayLength -i - 1}");
    }
}


string PrintArray(string[] Array, int ArrayLength)
{
    Console.WriteLine("Ваш массив: ");
    for(int i = 0; i < ArrayLength; i++)
    {
        Console.Write($"{Array[i]} ");
    }
}


// string NewArrayLessOrEquallyThreeSimbols()
// {

// }

Console.WriteLine("Введите количество символов массива: ");
int ArrayLength = int.Parse(Console.ReadLine());
string[] Array = new string[ArrayLength];

FillArray(Array, ArrayLength);
PrintArray(Array, ArrayLength);
