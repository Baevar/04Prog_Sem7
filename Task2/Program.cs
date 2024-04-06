// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// Указание
// Использовать рекурсию.
// Пример
// 123 => 6
// 63 => 9

int SumDigitInNum(int numb)
{
    if (numb == 0)
    {
        return 0;
    }

    return (numb % 10) + SumDigitInNum(numb / 10);
}

Console.WriteLine("Введите число");
int numb = Convert.ToInt32(Console.ReadLine());

int result = SumDigitInNum(numb);

Console.WriteLine($"Симма цифр числа={result}");