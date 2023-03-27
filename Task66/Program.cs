Console.WriteLine("Введите целое положительное число M");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число N");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM > numberN)
{
    int sumNumber = SumNumber(numberM, numberN);
    Console.WriteLine(sumNumber);
}
else if (numberM < numberN)
{
    int sumNumber = SumNumber(numberN, numberM);
    Console.WriteLine(sumNumber);
}
else Console.WriteLine("Введены одинаковые числа");


int SumNumber(int num1, int num2)
{
    if(num1 < num2) return 0;
    else return num1 + SumNumber(num1 - 1, num2);
}


