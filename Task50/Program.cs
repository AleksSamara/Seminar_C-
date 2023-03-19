Console.WriteLine("Введите натуральное число - индекс по строке элемента массива: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число - индекс по столбцу элемента массива: ");
int numberB = Convert.ToInt32(Console.ReadLine());


int[,] array2d = CreateMatrixRndInt(5, 6, 1, 100);
if (numberA >= 0 && numberB >= 0)
{
    PrintMatrix(array2d);
    SearchElementMatrix(array2d, numberA, numberB);
}
else Console.WriteLine("Надо ввести целые положительные числа");

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


void SearchElementMatrix(int[,] matrix, int num1, int num2)
{
    if (num1 < matrix.GetLength(0) && num2 < matrix.GetLength(1))
    {
        Console.WriteLine($"Элемент с введенными индексами имеет значение - {matrix[num1, num2]}");
    }
    else Console.WriteLine("Такого элемента в массиве нет");
}

