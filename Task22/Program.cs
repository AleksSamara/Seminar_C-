Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

TableSquare(number);

void TableSquare(int num)
{
    int index = 1;
    while (index <= num)
    {
        Console.WriteLine($"{index, 4}   {index * index, 4}");
        index = index + 1;
    }
}
