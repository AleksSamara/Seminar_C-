Console.WriteLine("Введите число a");
int numbera = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
int numberb = Convert.ToInt32(Console.ReadLine());
if (numbera == numberb * numberb)
{
   Console.WriteLine("Число а является квадратом числа b"); 
}
else
{
   Console.WriteLine("Число a не является квадратом числа b");  
}
