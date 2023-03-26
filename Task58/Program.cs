Console.WriteLine("Введите натуральное число - количество строк первой матрицы: ");
int numberA1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число - количество столбцов первой матрицы: ");
int numberB1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число - количество строк второй матрицы: ");
int numberA2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число - количество столбцов второй матрицы: ");
int numberB2 = Convert.ToInt32(Console.ReadLine());


int[,] array2d1 = CreateMatrixRndInt(numberA1, numberB1, 1, 5);
PrintMatrix(array2d1);
Console.WriteLine();
int[,] array2d2 = CreateMatrixRndInt(numberA2, numberB2, 1, 5);
PrintMatrix(array2d2);
Console.WriteLine();
if(array2d1.GetLength(1) == array2d2.GetLength(0))
{
    Console.WriteLine("Произведением заданных матриц является следующая матрица:");
    Console.WriteLine();
    int[,] multyMatrix = MultiplyTwoMatrix(array2d1, array2d2);
    PrintMatrix(multyMatrix);
}
else Console.WriteLine("Невозможно сделать произведение матриц - количество столбцов первой матрицы должно быть равно количеству строк второй матрицы");


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

int[,] MultiplyTwoMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] newmatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            int result = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                result = result + matrix1[i, k] * matrix2[k, j];
            }
            newmatrix[i, j] = result;
        }
    }
    return newmatrix;
}
