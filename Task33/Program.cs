Console.WriteLine("Введите размер массива - любое натуральное число: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите любое натуральное число в диапозоне до 10: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArray(sizeArray, 0, 10);
PrintArray(array);

bool presenceNumber = PresenceNumber(array, number);
Console.WriteLine(presenceNumber ? "Введенное число есть в созданном массиве" : "Введенного числа нет в созданном массиве");


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

bool PresenceNumber(int[] arr, int num)
{
    int check = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] == num) check = check + 1;
    }
    return check > 0;
}

