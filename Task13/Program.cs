Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 99)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while (number > 999)
    {
        number = number / 10;
    }
    int thirdDigit = ThirdDigit(number);
    Console.WriteLine($"Третья цифра введённого числа -> {thirdDigit}");
}


int ThirdDigit(int num)
{
    int third = num % 10;
    return third;
}
