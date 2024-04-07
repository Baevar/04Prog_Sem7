// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.

// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 


void PrintReverseArray(int[] array, int count)       // рекурсивная функция для вывода массива в обтратном порядке
{

    if (count < 0)
    {
        return;
    }

    Console.Write($"{array[count]} ");

    PrintReverseArray(array, count - 1);

}

void PrintArray(int[] array)            // Вывод созданного массива на консоль
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i + 1 == array.Length)
        {
            Console.Write(array[i]);
        }
        else
        {
            Console.Write($"{array[i]}, ");
        }
    }
    Console.Write("]");
}

int[] CreateRandomArray(int size)       // Создаю массив из случайных чисел

{
    Random rnd = new Random();

    int[] arr = new int[size];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(1, 11);
    }
    return arr;
}

bool IsNaturalNumb(int numb)        // проверка, удовлетворяет ли введенное число условиям создания размера массива
{
    if (numb < 1)
    {
        Console.WriteLine("Некорректный ввод");
        return false;
    }
    return true;
}

Console.Write("Введите размер массива = ");

if (!Int32.TryParse(Console.ReadLine(), out int size))     //проверяю, является ли введенная строка числом
{
    Console.WriteLine("Некорректный ввод");

    return;
}

if (!IsNaturalNumb(size)) return;

int[] array = CreateRandomArray(size);

Console.WriteLine("Исходный массив:");

PrintArray(array);

Console.WriteLine();

Console.WriteLine("Вывод массива в обратном порядке на консоль:");

PrintReverseArray(array, array.Length - 1);
