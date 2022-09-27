double GetNumber(string name)
{
    Console.WriteLine("Введите " + name);
    return Convert.ToDouble(Console.ReadLine());
}
double CoordinatPoint(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double CP1(double x1, double x2)
    {
        return Math.Pow((x2 - x1), 2);
    }

    double CP2(double y1, double y2)
    {
        return Math.Pow((y2 - y1), 2);
    }

    double CP3(double z2, double z1)
    {
        return Math.Pow((z2 - z1), 2);
    }

    return Math.Sqrt((CP1(x1, x2)) + (CP2(y1, y2)) + (CP3(z1, z2)));
}
double x1 = GetNumber("x1");
double y1 = GetNumber("y1");
double x2 = GetNumber("x2");
double y2 = GetNumber("y2");
double z1 = GetNumber("z1");
double z2 = GetNumber("z2");

Console.WriteLine("Координаты точки: " + CoordinatPoint(x1, y1, x2, y2, z1, z2));
