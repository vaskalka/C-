void fillArray(int[] collection, int numOfNumber)
{
    Console.WriteLine($"Число вводимых чисел - {numOfNumber}");

    int index = 0;
    int remains = numOfNumber;

    for (int i = 0; i < numOfNumber; i++)
    {
        Console.WriteLine("Введите число: ");
        collection[i] = int.Parse(Console.ReadLine());
        Console.WriteLine($"Число под индексом [{i}] = {collection[i]} ");
        remains--;
        Console.WriteLine($"Осталось ввести чисел {remains}");
    }
    Console.WriteLine("Ввод окончен!");
}


void printArray(int[] collection, int numOfNumber)
{
    Console.WriteLine("Ваш массив: ");
    for (int i = 0; i < numOfNumber; i++)
    {
        Console.Write($"{collection[i]} ");
    }
}


void checkMoreThenZero(int[] collection, int numOfNumber)
{
    int nubOfChecked = 0;
    for (int i = 0; i < numOfNumber; i++)
    {
        if (collection[i] > 0)
        {
            nubOfChecked++;
        }
    }
    Console.WriteLine($"Количество чисел в массиве больше нуля = {nubOfChecked}");
}


Console.WriteLine("Сколько чисел вы хотите ввести? - ");
int M = int.Parse(Console.ReadLine());

int[] array = new int[M];

fillArray(array, M);
printArray(array, M);
checkMoreThenZero(array, M);