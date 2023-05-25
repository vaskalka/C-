void fillArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(100, 999);
        index++;
    }
}

void printArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        Console.WriteLine(collection[index]);
        index++;
    }
}

void countEvenNumber(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    int count = 0;
    while (index < Length)
    {
        int currentRemains = collection[index] % 2;
        if (currentRemains == 0)
        {
            Console.WriteLine($"Значение {collection[index]} четное");
            count++;
  
        } 
    index++;
    } 
    Console.WriteLine($"Четных значений в массиве - ({count})");
}

Console.WriteLine("Введите длинну массива");
int arrayLength = int.Parse(Console.ReadLine());

Console.WriteLine("Ваш массив:");
int[] array = new int[arrayLength];
fillArray(array);
printArray(array);
countEvenNumber(array);