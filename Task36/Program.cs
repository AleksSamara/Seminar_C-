Console.WriteLine("Введите размер массива - любое натуральное число: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArray(sizeArray, -20, 20);
PrintArray(array);

Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях в массиве, = {SumEvenPositionNumber(array)}");


int[] CreateArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
    Console.WriteLine();
}

int SumEvenPositionNumber(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i = i + 2)
    {
        result = result + arr[i];
    }
    return result;
}

