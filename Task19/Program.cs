Console.WriteLine("Введите натуральное пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 9999 && number < 100000)
{
    bool overturn = Overturn(number);
    Console.WriteLine(overturn ? "Да" : "Нет");
}
else
{
    Console.WriteLine("Необходимо ввести натуральное пятизначное число");
}

bool Overturn(int num)
{
    return num / 10000 == num % 10 && num / 1000 % 10 == num / 10 % 10;
}
