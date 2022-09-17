// Задача 43:
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
//  y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double FindX(double k1, double b1, double k2, double b2)
{
    // через систему 2-х уравнений типа y = k1*x + b1 и y = k2*x + b2 находим x
    // x = (b2 - b1) / (k1 - k2)
    return Math.Round((b2 - b1) / (k1 - k2), 1, MidpointRounding.AwayFromZero);
}

double FindY(double k1, double b1, double FindX)
{
    // для линейного уравнения типа y = k1*x + b1 находим y
    return Math.Round(k1 * FindX + b1, 1, MidpointRounding.AwayFromZero);
}


string task = "Поиск точек перечения прямых, заданных уровнениями:\n"
            + "\ty = k1 * x + b1, y = k2 * x + b2\n";
Console.Clear();
Console.WriteLine(task);

Console.Write("Задайте значение b1: ");
double indexB1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Задайте значение k1: ");
double indexK1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Задайте значение b2: ");
double indexB2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Задайте значение k2: ");
double indexK2 = Convert.ToDouble(Console.ReadLine());


if (indexK1 == indexK2 && indexB1 == indexB2) Console.WriteLine("Прямые совпадают.");
else if (indexK1 == indexK2) Console.WriteLine("Точек пересечения нет. Прямые параллельны.");
else
{
    string line1 = $"y = {indexK1}x + {indexB1}";
    string line2 = $"y = {indexK2}x + {indexB2}";
    double x = FindX(indexK1, indexB1, indexK2, indexB2);
    double y = FindY(indexK1, indexB1, x);
    Console.WriteLine($"Точка пересечения прямых {line1} и {line2} -> ({x}; {y})");
}
