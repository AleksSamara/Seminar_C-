Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());

int result = SumDidgitalsNumber(number);
Console.WriteLine(result);

int SumDidgitalsNumber(int num)
{
    if(num == 0) return 0;
    else return num % 10 + SumDidgitalsNumber(num / 10);
}

