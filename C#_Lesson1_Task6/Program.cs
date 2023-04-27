/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).
*/

Console.WriteLine("Привет! Введи число, проверим его на четность: ");
float A = float.Parse(Console.ReadLine());

float remainder = A % 2;
Console.WriteLine(remainder);

if(remainder == 0) 
{
    Console.Write("Число четное, остаток равен: ");
    Console.Write(remainder);  
}
else
{
    Console.Write("Число нечетное, остаток равен: ");
    Console.Write(remainder);      
}

