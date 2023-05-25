// //Вывести на экран все целые числа от 100 до 200, кратные 3
// Console.WriteLine("Числа от 100 до 200, кратные 3");

// int currentValue = 100;
// int reminder = 0;

// for (int i = 0; i < 100; i++)
// {
//     if (currentValue <= 200)
//         {
//             reminder = currentValue % 3;
//             if (reminder == 0) 
//             Console.WriteLine($"Число {currentValue} кратно 3");
//         }
//     currentValue++;
// }

// // Вывести на экран все целые числа от А до B, кратные заданному С

// Console.WriteLine("Введите число А");
// int A = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите число B");
// int B = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите число C");
// int C = int.Parse(Console.ReadLine());

// int currentValue = A;
// int reminder = 0;

// for (int i = A; i <= B; i++)
// {
//     reminder = currentValue % C;
//     if (reminder == 0)
//     Console.WriteLine($"Число {currentValue} кратно {C}");
//     currentValue++;
// }

// Найти сумму целых положительных чисел из промежутка от
// A до B, кратных 4

Console.WriteLine("Введите число A");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B");
int B = int.Parse(Console.ReadLine());

int currentValue = A;
int reminder = 0;
int summ = 0;

for (int i = A; i <= B; i++)
{
    reminder = currentValue % 4;
    if (reminder == 0) summ = summ + currentValue;
    currentValue++;
}

Console.WriteLine($"Сумма чисел в промежутке от {A} до {B}, кратных 4, равна {summ}");