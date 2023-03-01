Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool checkNumber = CheckNumber(number);
Console.WriteLine(checkNumber ? "Да" : "Нет");

bool CheckNumber(int num)
{
    return num % 7 == 0 && num % 23 == 0;
}

