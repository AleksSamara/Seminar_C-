Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1)
{
    int sumdigit = SumDigit(number);
    Console.WriteLine($"Сумма цифр числа {number} = {sumdigit}");
}
else
{
    Console.WriteLine("Необходимо ввести натуральное число");
}


int SumDigit(int num)
{
    int sum = 0;
    while (num >= 1)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}
