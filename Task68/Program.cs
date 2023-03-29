Console.WriteLine("Введите целое положительное число m");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число n");
int numberN = Convert.ToInt32(Console.ReadLine());

int functionAccerman = FunctionAccerman(numberM, numberN);
Console.WriteLine(functionAccerman);

int FunctionAccerman(int num1, int num2)
{
    if(num1 == 0) return num2 + 1;
    else
    {
        if((num1 != 0) && (num2 == 0)) return FunctionAccerman(num1 - 1, 1);
        else return FunctionAccerman(num1 - 1, FunctionAccerman(num1, num2 - 1));
    }
}

