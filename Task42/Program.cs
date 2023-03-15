Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(NumberConversion(number));

// string NumberConversion(int num)
// {
//     string result = string.Empty;
//     while (num > 0)
//     {
//         result = num % 2 + result;
//         num = num / 2;
//     }
//     return result;
// }

int NumberConversion(int num)
{
    int result = 0, dec = 1;
    while (num > 0)
    {
        result = result + num % 2 * dec;
        dec *= 10;
        num = num / 2;
    }
    return result;
}

