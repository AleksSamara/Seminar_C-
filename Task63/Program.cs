Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());

NaturalNumbers(number);
Console.WriteLine();

void NaturalNumbers(int num)
{
    if(num == 0) return;
    NaturalNumbers(num - 1);
    Console.Write($"{num} ");
}
