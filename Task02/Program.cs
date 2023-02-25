Console.WriteLine("Введите первое число a");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число b");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB)
{
    Console.WriteLine("Число a больше числа b"); 
}
else if (numberB > numberA)
{
    Console.WriteLine("Число b больше числа a"); 
}
else
{
    Console.WriteLine("Числа a и b одинаковые"); 
}
