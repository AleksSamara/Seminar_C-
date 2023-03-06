Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    int fact = Fact(number);
    Console.WriteLine($"Факториал от единицы до {number} = {fact}");
}
else
{
    Console.WriteLine("Необходимо ввести целое положительное число");
}

int Fact(int num)
{
    int result = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            result = result * i;
        }
    }
    return result;
}

