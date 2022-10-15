// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите число 1 : ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число 2 : ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число 3 : ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число 4 : ");
double k2 = Convert.ToDouble(Console.ReadLine());

void Coordinates()
{
    if (k1 == k2)
    {
        Console.WriteLine("Линии не пересекаются.");
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k2 * x + b2;
        Console.WriteLine($"Координаты пересечения: ({x};{y})");
    }
}

Coordinates();