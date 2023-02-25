Console.WriteLine("Введите натуральное число N больше 1");
int N = Convert.ToInt32(Console.ReadLine());
int index = 2;
if (N > 1)
{
    Console.WriteLine("В диапозоне от 1 до N найдены чётные числа: ");
    while (index <= N)
    {
       Console.Write(index);
       Console.Write(", ");
       index = index + 2;
    }
    Console.WriteLine();
}
else
{
    Console.WriteLine("Введите натуральное число больше 1");
}
