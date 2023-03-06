Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int quantDigit = QuantDigit(number);
    Console.WriteLine($"В числе {number} количество разрядов = {quantDigit}");

int QuantDigit(int num)
{
    int sum = 0;
    while (num != 0)
    {
        num = num / 10;
        sum = sum + 1;
    }
    return sum;
}

