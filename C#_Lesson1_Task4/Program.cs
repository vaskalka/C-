/*
Задача 4: Напишите программу, которая принимает на вход три 
числа и выдаёт максимальное из этих чисел.
*/

Console.WriteLine("Привет! Введите первое число: ");
float A = float.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
float B = float.Parse(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
float C = float.Parse(Console.ReadLine());

float max = A;


if(A > max) max = A;
if(B > max) max = B;
if(C > max) max = C;

Console.Write("Максимальное число: ");
Console.Write(max);
