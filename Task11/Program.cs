int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100-999 -> {number}");
int firstDigit = number / 100;
int thirdDigit = number % 10;

int result = firstDigit * 10 + thirdDigit;
Console.WriteLine($"Результат -> {result}");

int delSecondDigit = DelSecondDigit(number);
Console.WriteLine($"Результат -> {delSecondDigit}");

int DelSecondDigit(int num)
{
    int firstDigit = number / 100;
    int thirdDigit = number % 10;
    int summ = firstDigit * 10 + thirdDigit;
    return summ;
}

