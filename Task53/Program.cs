Console.WriteLine("Введите натуральное число - количество строк массива: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число - количество столбцов массива: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int[,] array2d = CreateMatrixRndInt(numberA, numberB, 1, 10);
PrintMatrix(array2d);
Console.WriteLine();
ChangeFirstAndLastRows(array2d);
PrintMatrix(array2d);



int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix [i, j] = rand.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 5} ");
        }
        Console.WriteLine("|");
    }
}

void ChangeFirstAndLastRows(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int timeNumber = matrix[0, i];
        matrix[0, i] = matrix[matrix.GetLength(0)-1, i];
        matrix[matrix.GetLength(0)-1, i] = timeNumber;
    }
}
