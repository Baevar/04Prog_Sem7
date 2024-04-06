// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.

// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"


// Мой комментарий к задаче

//Не придумал как оформить в функцию проверки, что введеная строка является числом, поэтому нарушил правило DRY. Но главное работает

void PrintNaturalNumbers(int firstNumb, int secondNumb, int count)      // Рекурсивная функция вывода натуральных чисел
{
    if (firstNumb != secondNumb)
        Console.Write($"{firstNumb}, ");
    else
    {
        Console.Write($"{firstNumb} ");
        return;
    }
    firstNumb += count;
    PrintNaturalNumbers(firstNumb, secondNumb, count);
}

bool IsNaturalNumb(int numb)        // проверка, является ли введденое число натуральным
{
    if (numb < 1)
    {
        Console.WriteLine("Вы ввели не натуральное число, некорректный ввод");
        return false;
    }
    return true;
}

Console.WriteLine("Введите первое натуральное число");

if (!Int32.TryParse(Console.ReadLine(), out int firstNumb))     //проверяю, является ли введенная строка числом
{
    Console.WriteLine("Некорректный ввод");
    return;
}

if (!IsNaturalNumb(firstNumb)) return;          // проверяю, является ли введенное число натуральным

Console.WriteLine("Введите второе натуральное число");

if (!Int32.TryParse(Console.ReadLine(), out int secondNumb))    //проверяю, является ли введенная строка числом
{
    Console.WriteLine("Некорректный ввод");
    return;
}

if (!IsNaturalNumb(secondNumb)) return;         // проверяю, является ли введенное число натуральным

int count = 1;

if (firstNumb > secondNumb) count = -1;         // проверяю, какое из чисел больше 

PrintNaturalNumbers(firstNumb, secondNumb, count);
