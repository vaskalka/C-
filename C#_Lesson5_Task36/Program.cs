void fillArray (int[] collection)
{
    int index = 0;
    while (index < collection.Length)
    {
        collection[index] = new Random().Next(-10, 10);
        index++;
    }
}

void printArray (int[] collection)
{
    int index = 0;
    while (index < collection.Length)
    {
        Console.Write($"{collection[index]} ");
        index++;
    }
    Console.WriteLine();
}

void sumOddPositionArrayNumber (int[] collection)
{
    int index = 0;
    int sum = 0;
    while (index < collection.Length)
    {
        int currentIndex = index % 2;
        if (currentIndex == 1)
        {
            Console.WriteLine($"{collection[index]} находится на нечетной позиции");
            sum = sum + collection[index];
        }
        index ++;
    }
    Console.WriteLine($"Сумма значений на нечетных местах равна: {sum}");
    // нечетная позиция - по нумерации массива, т.е. отсчет от 0
}

Console.WriteLine("Введите длинну массива");
int arrayLength = int.Parse(Console.ReadLine());

Console.WriteLine("Ваш массив:");
int[] array = new int[arrayLength];

fillArray(array);
printArray(array);
sumOddPositionArrayNumber(array);