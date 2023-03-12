Console.WriteLine("Введите размер массива - любое натуральное число: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArray(sizeArray, 100, 999);
PrintArray(array);

Console.WriteLine($"Количество чётных элементов в массиве = {QuantityEvenNumber(array)}");


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

int QuantityEvenNumber(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0) result += 1;
    }
    return result;
}

