Console.WriteLine("Введите число a");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
int number2 = Convert.ToInt32(Console.ReadLine());

// int result = numA % numB;
// if (result == 0)
// {
//    Console.WriteLine($"Число {numA} кратно числу {numB}"); 
// }
// else
// {
//    Console.WriteLine($"Число {numA} некратно числу {numB}, остаток от деления {result}");  
// }


int multyPlicity = MultyPlicity(number1, number2);
if (multyPlicity == 0)
{
   Console.WriteLine($"Число {number1} кратно числу {number2}"); 
}
else
{
   Console.WriteLine($"Число {number1} некратно числу {number2}, остаток от деления {multyPlicity}");  
}

int MultyPlicity(int num1, int num2)
{
    return num1 % num2;
}

