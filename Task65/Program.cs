Console.WriteLine("Введите целое положительное число M");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число N");
int numberN = Convert.ToInt32(Console.ReadLine());

NaturalNumbersInterval(numberM, numberN);
Console.WriteLine();

void NaturalNumbersInterval(int num1, int num2)
{
    if(num1 > num2)
    {
        Console.Write($"{num1} ");
        NaturalNumbersInterval(num1 - 1, num2);
    }
    else if(num1 < num2)
    {
        NaturalNumbersInterval(num1, num2 - 1);
        Console.Write($"{num2} ");
    }
    else Console.Write($"{num2} ");
}


