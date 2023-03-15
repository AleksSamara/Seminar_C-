Console.WriteLine("Введите натуральное число M - столько чисел необходимо будет ввести: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());


int[] array = CreateArray(sizeArray);
Console.WriteLine($"Количество чисел больше нуля = {QuantityMoreNull(array)}");

int[] CreateArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите число: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int QuantityMoreNull(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) result += 1;
    }
    return result;
}
