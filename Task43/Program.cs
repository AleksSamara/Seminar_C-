Console.WriteLine("Для расчета точки пересечения двух прямых y=k1*X+b1 и у=k2*X+b2 необходимо ввести значения k1, b1, k2 и b2");
Console.WriteLine("Введите значение k1: ");
int numK1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b1: ");
int numB1= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k2: ");
int numK2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
int numB2 = Convert.ToInt32(Console.ReadLine());

if (numK1 == numK2 && numB1 == numB2) Console.WriteLine("Точки пересечения прямых нет, они совпадают");
else if (numK1 == numK2 || numB1 == numB2) Console.WriteLine("Точки пересечения прямых нет, они параллельны");
else Console.WriteLine($"Точка пересечения двух прямых имеет координаты: ({SearchX(numK1, numB1, numK2, numB2)}; {SearchY(SearchX(numK1, numB1, numK2, numB2), numK1, numB1)})");


double SearchX(int num1, int num2, int num3, int num4)
{
    double result = (num4 - num2) / (num1 - num3);
    return result;
}

double SearchY(double numberX, int num1, int num2)
{
    double result = num1 * numberX + num2;
    return result;
}
