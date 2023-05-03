// //Вывод двумерного массива 
// void PrintArray(int[,] matr)
// {
//     for (int rows = 0; rows < matr.GetLength(0); rows++)
//     {
//         for (int columns = 0; columns < matr.GetLength(1); columns++)
//         {
//             Console.Write($"{matr[rows, columns]} ");
//         }
//         Console.WriteLine();
//     }    
// }

// void FillArray(int[,] matr)
// {
//     for (int rows = 0; rows < matr.GetLength(0); rows++)
//     {
//         for (int columns = 0; columns < matr.GetLength(1); columns++)
//         {
//             matr[rows, columns] = new Random().Next(1,10);
//         }
//     }
// }

// int[,] matrix = new int[3, 4];
// FillArray(matrix);
// PrintArray(matrix);

// // Первая рекурсия, вывод факториала
// double Factorial (int n)
// {
//     if (n == 1) return 1;
//     else return n * Factorial(n-1);
// }
// for (int i = 1; i < 20; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");
// }

// Вторая реурсия, вывод последовательности Фибоначи
int Fibonacci (int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}

for (int i = 1; i < 20; i++)
{
    Console.Write($"{Fibonacci(i)} ");
}