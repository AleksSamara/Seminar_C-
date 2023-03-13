Console.WriteLine("Введите первое натуральное число a: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число b: ");
int numberB= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье натуральное число c: ");
int numberC = Convert.ToInt32(Console.ReadLine());

bool triangle = Triangle(numberA, numberB, numberC);
Console.WriteLine(triangle ? "Эти числа могут быть сторонами треугольника" : "Эти числа не могут быть сторонами треугольника");

bool Triangle(int num1, int num2, int num3)
{
    if (num1 < num2 + num3 && num2 < num1 + num3 && num3 < num1 + num2) return true;
    else return false;
}
