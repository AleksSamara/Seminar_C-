Console.WriteLine("Введите натуральное число N больше единицы для вывода первых N-чисел ряда Фибоначчи: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

if (sizeArray > 1)
{
    int[] array = CreateArray(sizeArray);
    PrintArray(array);
}
else Console.WriteLine("Надо ввести натуральное число больше единицы");



int[] CreateArray(int size)
{
    int[] arr = new int[size];
    arr[0] = 0;
    arr[1] = 1;
    for (int i = 2; i < size; i++)
    {
        arr[i] = arr [i - 1] + arr[i - 2];
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
