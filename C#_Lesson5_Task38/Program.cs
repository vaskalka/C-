void fillArray(double[] collection)
{
    int index = 0;
    while (index < collection.Length)
    {
        collection[index] = new Random().Next(1, 100);
        index++;
    }
}

void printArray(double[] collection)
{
    int index = 0;
    while (index < collection.Length)
    {
        Console.Write($"{collection[index]} ");
        index++;
    }
    Console.WriteLine();
}

void subtractionBetweenMaxMin (double[] collection)
{
    int index = 0;
    double min = collection[index];
    double max = collection[index];

    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[index] < min) min = collection[index];
        if (collection[index] > max) max = collection[index];
        index++;
    }

    Console.WriteLine($"Минимальный элемент массива: {min}");
    Console.WriteLine($"Максимальный элемент массива: {max}");

    double difference = max - min;
    Console.WriteLine($"Разница: {max} - {min} = {difference}");
}

Console.WriteLine("Введите длину массива");
int arrayLength = int.Parse(Console.ReadLine());

Console.WriteLine("Ваш маасив");
double[] array = new double[arrayLength];
fillArray(array);
printArray(array);
subtractionBetweenMaxMin(array);