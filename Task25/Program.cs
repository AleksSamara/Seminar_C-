Console.WriteLine("Введите целое число a: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число b: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number2 > 0)
{
    int degree = Degree(number1, number2);
    Console.WriteLine($"Число {number1} в степени {number2} = {degree}");
}
else
{
    Console.WriteLine("Необходимо ввести натуральное число b");
}


int Degree(int num1, int num2)
{
    int result = 1;
    for (int i = 1; i <= num2; i++)
    {
        result = result * num1;
    }
        return result;
}
