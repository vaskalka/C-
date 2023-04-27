Console.WriteLine("Введите первое число: ");
float A = float.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
float B = float.Parse(Console.ReadLine());

if(A>B)
{   
    Console.Write("Число ");
    Console.Write(A);
    Console.Write(" больше числа ");
    Console.Write(B);
}
else
{
    Console.Write("Число ");
    Console.Write(B);
    Console.Write(" больше числа ");
    Console.Write(A);    
}