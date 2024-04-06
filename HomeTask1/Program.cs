// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.

// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"


void PrintNaturalNumbers(int firstNumb, int secondNumb)
{

    
    if (firstNumb <= secondNumb)
    {
        if (firstNumb > 0)
        {
            Console.Write($"{firstNumb} ");
        }
    }
    else
    {
        return;
    }
    PrintNaturalNumbers(firstNumb+1, secondNumb);
}


Console.WriteLine("Введите первое число");
int firstNumb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int secondNumb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Натуральные числа в промежутке от первого до второго числа:");

if (firstNumb > secondNumb)
{
    Console.WriteLine("Не корректный ввод");
    return;
}

PrintNaturalNumbers(firstNumb, secondNumb);