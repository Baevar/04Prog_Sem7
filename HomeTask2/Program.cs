// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 

// m = 2, n = 3 -> A(m,n) = 29
// m = 11, n = 3 -> A(m,n) = 16381

//Мой комментарий по задаче

// В примерах выше коэффициенты m и n перепутаны местати. 
// Согласно готовой таблице Решения функции Аккермана при m = 2, n = 3 результат будет равен 9
// а при m = 11, n = 3 будет нескончаемо большой. А вот при m = 3, n = 2 результат будет равен 29
// и при m = 3, n = 11 результат будет равен 16381. 
// Собственно можно сделать вывод, что в примере коэффициенты функции m и n перепутаны местами.
// Решение ниже корректно.

int FunkAckerman(int firstNumb, int secondNumb)
{
    if (firstNumb == 0)
    {
        return secondNumb + 1;
    }
    else if (secondNumb == 0)
    {
        return FunkAckerman(firstNumb - 1, 1);
    }

    return FunkAckerman(firstNumb - 1, FunkAckerman(firstNumb, secondNumb - 1));
}



bool IsNaturalNumb(int numb)        // проверка, является ли введденое число натуральным
{
    if (numb < 0)
    {
        Console.WriteLine("Число меньше нуля, некорректный ввод");
        return false;
    }
    return true;
}

Console.WriteLine("Введите первое число");

if (!Int32.TryParse(Console.ReadLine(), out int firstNumb))     //проверяю, является ли введенная строка числом
{
    Console.WriteLine("Некорректный ввод");
    return;
}

if (!IsNaturalNumb(firstNumb)) return;          // проверяю, является ли введенное число натуральным

Console.WriteLine("Введите второе число");

if (!Int32.TryParse(Console.ReadLine(), out int secondNumb))    //проверяю, является ли введенная строка числом
{
    Console.WriteLine("Некорректный ввод");
    return;
}

if (!IsNaturalNumb(secondNumb)) return;         // проверяю, является ли введенное число натуральным

int result = FunkAckerman(firstNumb, secondNumb);
Console.WriteLine($"Результат функции Аккермана пары чисел {firstNumb} и {secondNumb} равен = {result}");