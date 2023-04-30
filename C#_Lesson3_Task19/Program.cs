/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
*/

Console.WriteLine("Введи число: ");
int number = int.Parse(Console.ReadLine());
int reversed = 0; // число в обратном порядке

int remaindedValue(int number)
{
    while (number > 0) // пока есть цифры в исходном числе
    {
        int remainder = number % 10; // находим последнюю цифру заданного числа 
        reversed = reversed * 10 + remainder; // добавляем ее в начало нового числа
        number = number / 10; // удаляем последнюю цифру из исходного числа
    }
    return reversed; // возвращаем обратное число
}

int newRemaindedValue = remaindedValue(number);
Console.WriteLine("Ваше развернутое число: " + newRemaindedValue);

if (number == newRemaindedValue) Console.WriteLine("Ваше число является палиндромом");
else Console.WriteLine("Ваше число не является палиндромом");