﻿Console.WriteLine("Введите размер массива - любое натуральное число: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArray(sizeArray, 1, 9);
PrintArray(array);
ReverseArray(array);
PrintArray(array);


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

// Array.ReverseArray(array);

void ReverseArray(int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int temp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp;
    }
}

