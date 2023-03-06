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
    int result = 0;
    for (int i = 1; i <= num; i++)
    {
        result = result + i;
    }
    return result;
}

