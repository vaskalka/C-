/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
*/

Console.WriteLine("Введите положительное число");
string Number = Console.ReadLine();

int sum = 0;

for (int i = 0; i < Number.Length; i++)
{
    int curValue = int.Parse(Number[i].ToString());
    sum += curValue;
}

Console.WriteLine($"Сумма чисел в {Number} = {sum}");
