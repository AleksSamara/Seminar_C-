Console.WriteLine("Введите натуральное число - количество строк массива: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число - количество столбцов массива: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int[,] array2d = CreateMatrixRndInt(numberA, numberB, 1, 10);
PrintMatrix(array2d);
Console.WriteLine();
int[] newarray = MinElemIndex(array2d);
int[,] newArray2d = DeleteMinRowColumn(array2d, newarray[0], newarray[1]);
PrintMatrix(newArray2d);


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

int[] MinElemIndex(int[,] matrix)
{
    int row = 0;
    int column = 0;    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < matrix[row, column])
            {
                row = i;
                column =j;
            }
        }
    }
    return new int[]{row, column};
}

int[,] DeleteMinRowColumn(int[,] matrix, int rowDel, int columnDel)
{
    int[,] newArray2d = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int m = 0, n = 0;
    for (int i = 0; i < newArray2d.GetLength(0); i++)
    {
        if (m == rowDel) m++;
        for (int j = 0; j < newArray2d.GetLength(1); j++)
        {
            if (n == columnDel) n++;
            newArray2d[i, j] = matrix[m, n];
            n++;
        }
        n = 0;
        m++;
    }
    return newArray2d;
}
