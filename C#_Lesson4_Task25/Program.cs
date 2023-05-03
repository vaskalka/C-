/*
Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
*/

int Degree(int n, int b)
{
    int result = 1;
    for (int i = 0; i < b; i++)
    {
        result *= n;
    }
    return result;
}

Console.WriteLine("Введите число A для возведения его в степень B");
int arg1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите натуральную степень B");
int deg1 = int.Parse(Console.ReadLine());
Console.WriteLine($"{arg1}^{deg1} = {Degree(arg1, deg1)}");
