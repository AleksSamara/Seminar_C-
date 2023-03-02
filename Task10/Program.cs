Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100 || number > 999)
{
    Console.WriteLine("Надо ввести трехзначное число");
}
else
{
    int secondDigit = SecondDigit(number);
    Console.WriteLine($"Вторая цифра введённого числа -> {secondDigit}");
}


int SecondDigit(int num)
{
    int firstTwoDigit = num / 10;
    int second = firstTwoDigit % 10;
    return second;
}
