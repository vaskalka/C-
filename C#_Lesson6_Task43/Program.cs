void mathdoubleersection (double k1, double b1, double k2, double b2)
{
    double check = k1 - k2;
    if (check == 0) 
    {
        Console.WriteLine("Прямые имеют одинаковый угол наклона, пересечения нет");        
    }
    else
    {
        double x = (b2 - b1)/(k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Точка пересечения y = {y}, x = {x}");        
    }
}

Console.WriteLine("Введите значения для первой прямой: ");
Console.Write("Введите k1 = ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("Введите b1 = ");
double b1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите значения для второй прямой: ");
Console.Write("Введите k2 = ");
double k2 = double.Parse(Console.ReadLine());
Console.Write("Введите b2 = ");
double b2 = double.Parse(Console.ReadLine());

mathdoubleersection(k1, b1, k2, b2);