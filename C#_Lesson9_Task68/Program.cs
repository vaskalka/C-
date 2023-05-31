/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
*/

double ackermannFunction(int Value1, int Value2)
{
    if (Value1 > -1 && Value2 > -1)
    {
        if (Value1 == 0) 
            return Value2+1;

        else if (Value1 > 0 && Value2 == 0)
            return ackermannFunction(Value1 -1, 1);

        else 
            return ackermannFunction(Value1-1, (int)ackermannFunction(Value1, Value2-1));
    }
    else throw new ArgumentException("Значения должны быть неотрицательными.");
}


Console.WriteLine("Введите первое неотрицательное число M");
int M = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе неотрицательное число N");
int N = int.Parse(Console.ReadLine());

double result = ackermannFunction(M, N);
Console.WriteLine($"Значение функции A({M}, {N}) = {result}");