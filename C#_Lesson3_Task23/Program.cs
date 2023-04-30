/*
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
*/

void mathCube()
{
    Console.WriteLine("Введите число N (где N > 0), до которого будут посчитаны кубы: ");
    int arg = int.Parse(Console.ReadLine());
    int currValue = 1;
    double cubedValue = 0;

    if (arg > 0)
    {
        for (int i = 0; i < arg; i++)
        {
            cubedValue = Math.Pow(currValue, 3);
            Console.WriteLine($"Куб числа {currValue} = {cubedValue}");
            currValue ++;
        }        
    }
    else Console.WriteLine("N <= 0!");
}

mathCube();