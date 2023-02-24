Console.WriteLine("Введите число a");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA == numberB * numberB)
{
   Console.WriteLine("Число а является квадратом числа b"); 
}
else
{
   Console.WriteLine("Число a не является квадратом числа b");  
}
