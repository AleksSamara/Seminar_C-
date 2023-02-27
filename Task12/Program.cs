Console.WriteLine("Введите число a");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
int numberB = Convert.ToInt32(Console.ReadLine());

int result = numberA % numberB;
if (result == 0)
{
   Console.WriteLine($"Число {numberA} кратно числу {numberB}"); 
}
else
{
   Console.WriteLine($"Число {numberA} некратно числу {numberB}, остаток от деления {result}");  
}


int Multiplicity(int numA, int numB)
{
    return numA % numB;
}


