Console.WriteLine("Введите натуральное число - количество строк массива: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число - количество столбцов массива: ");
int numberB = Convert.ToInt32(Console.ReadLine());

double[,] array2d = CreateMatrixRndDouble(numberA, numberB, 1, 10);
PrintMatrixDouble(array2d);


double[,] CreateMatrixRndDouble(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double num = rand.NextDouble() * (max - min) + min;
            matrix[i, j] = Math.Round(num, 1);
            // matrix[i, j] = rand.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrixDouble(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 6} ");
        }
        Console.WriteLine("|");
    }
}

