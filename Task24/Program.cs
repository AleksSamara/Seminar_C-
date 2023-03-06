Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 1)
{
    int sumNumbers = SumNumbers(number);
    Console.WriteLine($"Сумма чисел от единицы до {number} = {sumNumbers}");
}
else
{
    Console.WriteLine("Необходимо ввести целое положительное число");
}

int SumNumbers(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum = sum + i;
    }
    return sum;
}

