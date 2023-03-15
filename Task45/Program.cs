Console.WriteLine("Введите натуральное число - размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());


int[] array = CreateArray(sizeArray, 0, 10);
PrintArray(array);
int[] newArray = NewArray(array);
PrintArray(newArray);

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

int[] NewArray(int[] arr)
{
    int[] newArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        newArr[i] = arr[i];
    }
    return newArr;
}


