﻿/*
Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.
*/

Console.WriteLine("Введите число");
string arg1 = (Console.ReadLine());

if(arg1.Length > 2)
{
    char ch = arg1[2];
    Console.WriteLine("Третья цифра в введенном числе: " + ch);
}
else Console.WriteLine("В введенном числе нет третьего символа");
//P.S. Также не вижу смысла в использовании метода в данной задаче,
//в связи с малым количеством действий.
//Если необходимы мат. операции с этим числом - можем его запарсить в int и т.д.

//P.S_2. Работает только с положительными, т.к. мы вводим строку, т.е. символ "-"
//будет считаться за элемент строкового массива. В задании стоит уточнить, с
//какими именно числами должна работать программа)