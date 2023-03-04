Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    TableSquare(number);
}
else
{
    Console.WriteLine("Необходимо ввести натуральное число");
}

void TableSquare(int num)
{
    int index = 1;
    while (index <= num)
    {
        Console.WriteLine($"{index, 4}   {index * index * index, 4}");
        index = index + 1;
    }
}
