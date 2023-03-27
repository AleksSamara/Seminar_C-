Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    NaturalNumbers(number);
    Console.WriteLine();
}
else Console.WriteLine("Надо ввести целое положительное число");


void NaturalNumbers(int num)
{
    if(num == 0) return;
    Console.Write($"{num} ");
    NaturalNumbers(num - 1);   
}
