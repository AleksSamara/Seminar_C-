Console.WriteLine("Введите номер четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Range(quarter));


string Range(int num)
{
    if(num == 1) return "Диапозон значений: X > 0 и Y > 0";
    if(num == 2) return "Диапозон значений: X < 0 и Y > 0";
    if(num == 3) return "Диапозон значений: X < 0 и Y < 0";
    if(num == 4) return "Диапозон значений: X > 0 и Y < 0";
    return "Такой четверти не существует";
}

