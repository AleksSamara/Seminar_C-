int[] array = CreateArray(123, 0, 200);
PrintArray(array);

Console.WriteLine($"Для полученного массива количество чисел в диапозоне от 10 до 99 включительно = {QuantityRightNumber(array)}");


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

int QuantityRightNumber(int[] arr)
{
    int quantity = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 9 && arr[i] < 100) quantity = quantity + 1;
    }
    return quantity;
}

