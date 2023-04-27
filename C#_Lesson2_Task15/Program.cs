/*
Напишите программу, которая принимает на вход цифру, обозначающую 
день недели, и проверяет, является ли этот день выходным.
*/

Console.WriteLine("Привет, введи число: ");
int arg1 = int.Parse(Console.ReadLine());

if(arg1 > 0 && arg1 < 8)
{
    if(arg1 > 5 && arg1 < 8) Console.WriteLine("Крутяк, выходные!");
    if(arg1 > 0 && arg1 < 6) Console.WriteLine("Кажется пора на работу :с ");
}
else Console.WriteLine("Введенное число не похоже на день недели :с ");