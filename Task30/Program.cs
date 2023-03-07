int[] array = new int[8];

FillArray(array);
WriteArray(array);
Console.WriteLine();

void FillArray(int[] arr)
{
        for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 2);
    }
}

void WriteArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]+ " ");
    }
}
