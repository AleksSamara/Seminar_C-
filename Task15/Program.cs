Console.WriteLine("Введите порядковый номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1 || number > 7)
{
    Console.WriteLine("Такого порядкового дня недели не существует");
}
else
{
    bool freeDay = FreeDay(number);
    Console.WriteLine(freeDay ? "Да" : "Нет");
}


bool FreeDay(int num)
{
    return num == 6 || num == 7;
}

