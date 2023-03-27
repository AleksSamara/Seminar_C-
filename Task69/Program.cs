Console.WriteLine("Введите целое положительное число A");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число B");
int numberB = Convert.ToInt32(Console.ReadLine());

int multi = MultiNumbers(numberA, numberB);
Console.WriteLine(multi);

int MultiNumbers(int num1, int num2)
{
    if(num2 == 0) return 1;
    else return checked (num1 * MultiNumbers(num1, num2 - 1));
}

