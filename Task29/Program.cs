int[] array = new int[8];

FillArray(array);
WriteArray1(array);
Console.Write(" -> [");
WriteArray1(array);
Console.Write("]");
Console.WriteLine();

void FillArray(int[] arr)
{
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(0, 100);
    }
}

void WriteArray1(int[] arr)
{
    int ii = 0;
    for (int i = 0; i < (arr.Length - 1); i++)
    {
        Console.Write(arr[i]+ ", ");
        ii = i;
    }
    ii = ii + 1;
    Console.Write(arr[ii]);
}
