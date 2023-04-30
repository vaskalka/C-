/*
Напишите программу, которая принимает на вход координаты двух 
точек и находит расстояние между ними в 3D пространстве.
*/

void Distance(string[] args)
{
    Console.WriteLine("Введите координаты 1-ой точки: x1, y1, z1 ");
    string[] Point1 = Console.ReadLine().Split();

    Console.WriteLine("Введите координаты 2-ой точки: x2, y2, z2 ");
    string[] Point2 = Console.ReadLine().Split();

    double x1 = double.Parse(Point1[0]);
    double y1 = double.Parse(Point1[1]);
    double z1 = double.Parse(Point1[2]);

    double x2 = double.Parse(Point2[0]);
    double y2 = double.Parse(Point2[1]);
    double z2 = double.Parse(Point2[2]);

    double distance = Math.Sqrt(
        Math.Pow(x2 - x1, 2) + 
        Math.Pow(y2 - y1, 2) + 
        Math.Pow(z2 - z1, 2));

    Console.WriteLine($"Расстояние между точками ({x1}, {y1}, {z1}) и" +
    $" ({x2}, {y2}, {z2}) = {distance}");
}

Distance(args); // вызов метода Distance
