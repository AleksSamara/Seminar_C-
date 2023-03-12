Console.WriteLine("Введите размер массива - любое натуральное число: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

double[] array = CreateArray(sizeArray, 0, 20);
PrintArray(array);

Console.WriteLine($"Разница между максимальным и минимальным чмслом в массиве = {DifferenceMaxNumberAndMinNumber(array)}");


double[] CreateArray(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        double num = rand.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]},  ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
    Console.WriteLine();
}

double DifferenceMaxNumberAndMinNumber(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    for (int i = 0; i < arr.Length; i += 1)
    {
        if(arr[i] > max) max = arr[i];
        if(arr[i] < min) min = arr[i];
    }
    return Math.Round(max - min, 1);
}
