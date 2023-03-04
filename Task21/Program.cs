Console.WriteLine("Введите координаты первой точки");
Console.Write("X: ");
int xCoord1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoord1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int zCoord1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
Console.Write("X: ");
int xCoord2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoord2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int zCoord2 = Convert.ToInt32(Console.ReadLine());


double length = Length(xCoord1, yCoord1, zCoord1, xCoord2, yCoord2, zCoord2);
Console.WriteLine($"Расстояние между точками равно - {Math.Round(length, 2, MidpointRounding.ToZero)}");



double Length(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));
}
