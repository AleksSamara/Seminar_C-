Console.WriteLine("Введите координаты первой точки");
Console.Write("X: ");
int xCoordinate1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoordinate1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
Console.Write("X: ");
int xCoordinate2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoordinate2 = Convert.ToInt32(Console.ReadLine());


double length = Length(xCoordinate1, yCoordinate1, xCoordinate2, yCoordinate2);
Console.WriteLine(Math.Round(length, 2, MidpointRounding.ToZero));



double Length(int x1, int y1, int x2, int y2)
{
    return Math.Sqrt((x2-x1) * (x2-x1) + (y2-y1) * (y2-y1));
}

