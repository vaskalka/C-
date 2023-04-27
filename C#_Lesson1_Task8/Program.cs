/*
Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
*/

Console.WriteLine("Привет, введи число, а я выведу список четных от 1 до твоего числа: ");
float A = float.Parse(Console.ReadLine());
Console.Write("Твоё число: ");
Console.WriteLine(A);

Console.WriteLine("А вот последовательность четных чисел от 1, до твоего числа: ");

int count = 0;
float remainder, B = A;

if(A > 0)
{
    while(count < Math.Abs(A)) 
    {   
        remainder = B % 2;
        if(remainder == 0) Console.WriteLine(B);
        count++;
        B--; 
    } 
}
// Тут, конечно, ещё можно добавить проверку, если число = 0, но,
// если честно, уже немного лениво, работает и без неё :)
else
{
    while(count < Math.Abs(A)) 
    {   
        remainder = B % 2;
        if(remainder == 0) Console.WriteLine(B);
        count++;
        B++; 
    }     
}
