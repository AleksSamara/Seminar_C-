Console.WriteLine("Введите количество элементов массива - натуральное число меньше 10");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 0 || number >=10) Console.WriteLine("Необходимо ввести натуральное число меньше 10");
else
{
    string[] firstArray = new string [number];
    CreateArray(firstArray);
    PrintArray(firstArray);
    string[] secondArray = new string [CountSizeNewArray(firstArray)];
    NewArray(firstArray, secondArray);
    PrintArray(secondArray);
}



void CreateArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine("Введите следующий элемент массива - любой текст");
        arr[i]= Console.ReadLine();
    }
}


int CountSizeNewArray(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}


void NewArray(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= 3)
        {
            arr2[count] = arr1[i];
            count++;
        }
    }
}


void PrintArray(string[] arr)
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

